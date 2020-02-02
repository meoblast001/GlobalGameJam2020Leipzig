using UnityEngine;
using Zenject;

public class Rocket : MonoBehaviour
{
    public class Factory : PlaceholderFactory<Rocket>
    {
    }

    public float speed = 2f;

    void Update()
    {
        this.transform.localPosition += this.transform.localRotation * Vector3.forward * this.speed;
    }
}
