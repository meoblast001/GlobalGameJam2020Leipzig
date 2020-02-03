using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AntennaCharger : MonoBehaviour
{
    private Collider lastCollider;
    [Inject] private HealthStatus healthStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9 && other != lastCollider)
        {
            lastCollider = other;
            healthStatus.Shield += 1;
        }
    }

}
