using System;
using System.Collections;
using UnityEngine;
using Zenject;

public class RocketGenerator : MonoBehaviour
{
    public float generateRocketSeconds = 1f;

    [Inject]
    private Rocket.Factory rocketFactory;

    void Start()
    {
        this.StartCoroutine(this.GenerateRocket(() => this.generateRocketSeconds));
    }

    private IEnumerator GenerateRocket(Func<float> secondsCallback)
    {
        var rocket = this.rocketFactory.Create();
        yield return new WaitForSeconds(secondsCallback());
        this.StartCoroutine(this.GenerateRocket(secondsCallback));
    }
}
