using System;
using System.Collections;
using UnityEngine;
using Zenject;

public class RocketGenerator : MonoBehaviour
{
    public float rocketStartDistance = 50f;
    public float generateRocketSeconds = 1f;

    [SerializeField] GameObject player;

    private System.Random random = new System.Random();

    [Inject]
    private Rocket.Factory rocketFactory;

    void Start()
    {
        this.StartCoroutine(this.GenerateRocket(() => this.generateRocketSeconds));
    }

    private IEnumerator GenerateRocket(Func<float> secondsCallback)
    {
        var angle = (float) this.random.NextDouble() * 360f;
        var position = this.transform.position + (DegreeToVector(angle) * this.rocketStartDistance);

        var rocket = this.rocketFactory.Create();
        rocket.transform.SetParent(this.player.transform);
        rocket.transform.localPosition = position;
        rocket.transform.position
            = new Vector3(rocket.transform.position.x, this.transform.position.y, rocket.transform.position.z);
        var playerPos = this.player.transform.position;
        rocket.transform.LookAt(new Vector3(playerPos.x, rocket.transform.position.y, playerPos.z));

        yield return new WaitForSeconds(secondsCallback());
        this.StartCoroutine(this.GenerateRocket(secondsCallback));
    }

    private static Vector3 DegreeToVector(float degree)
    {
        float radian = degree * Mathf.Deg2Rad;
        return new Vector3(Mathf.Cos(radian), 0f, Mathf.Sin(radian));
    }
}
