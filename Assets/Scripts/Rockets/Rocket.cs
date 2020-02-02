using UnityEngine;
using Zenject;

public class Rocket : MonoBehaviour
{
    public class RocketFactory : PlaceholderFactory<Rocket>
    {
    }

    public class BigRocketFactory : PlaceholderFactory<Rocket>
    {
    }

    public float speed = 60f;
    public bool bigRocket = false;

    void Update()
    {
        this.transform.localPosition += this.transform.localRotation * Vector3.forward * this.speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
