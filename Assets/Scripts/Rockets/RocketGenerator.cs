using System;
using System.Collections;
using UnityEngine;
using Zenject;

public class RocketGenerator : MonoBehaviour
{
    public float rocketStartDistance = 300f;
    public float generateRocketSeconds = 1f;
    public float generateBigRocketSeconds = 30f;

    [SerializeField] GameObject player;

    private System.Random random = new System.Random();

    [Inject]
    private Rocket.RocketFactory rocketFactory;
    [Inject]
    private Rocket.BigRocketFactory bigRocketFactory;

    void Start()
    {
        this.StartCoroutine(this.GenerateRocket(this.rocketFactory, () => this.generateRocketSeconds));
        this.StartCoroutine(this.GenerateRocket(this.bigRocketFactory, () => generateBigRocketSeconds));
    }

    private IEnumerator GenerateRocket(PlaceholderFactory<Rocket> factory, Func<float> secondsCallback)
    {
        yield return new WaitForSeconds(secondsCallback());

        var angle = (float) this.random.NextDouble() * 360f;
        var position = this.transform.position + (DegreeToVector(angle) * this.rocketStartDistance);

        var rocket = factory.Create();
        rocket.transform.SetParent(this.player.transform);
        rocket.transform.localPosition = position;
        rocket.transform.position
            = new Vector3(rocket.transform.position.x, this.transform.position.y, rocket.transform.position.z);
        var playerPos = this.player.transform.position;
        rocket.transform.LookAt(new Vector3(playerPos.x, rocket.transform.position.y, playerPos.z));
        rocket.playerTransform = this.player.transform;
        rocket.originalDistanceToPlayer = Vector3.Distance(rocket.transform.position, this.player.transform.position);

        this.StartCoroutine(this.GenerateRocket(factory, secondsCallback));
    }

    private static Vector3 DegreeToVector(float degree)
    {
        float radian = degree * Mathf.Deg2Rad;
        return new Vector3(Mathf.Cos(radian), 0f, Mathf.Sin(radian));
    }
}
