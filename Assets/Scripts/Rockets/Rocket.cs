using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class Rocket : MonoBehaviour
{
    public class Factory : PlaceholderFactory<Rocket>
    {
    }

    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        this.rb.MovePosition(Vector3.forward * this.speed);
    }
}
