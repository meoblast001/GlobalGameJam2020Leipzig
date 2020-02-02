using UnityEngine;
using Zenject;

public class Rocket : MonoBehaviour
{
    private const int TicksUntilRemoveCheck = 30;
    private const float RemoveOvershootDistance = 10f;

    private int ticksSinceRemoveCheck = 0;

    public class RocketFactory : PlaceholderFactory<Rocket>
    {
    }

    public class BigRocketFactory : PlaceholderFactory<Rocket>
    {
    }

    public float speed = 60f;
    public bool bigRocket = false;

    public Transform playerTransform;
    public float originalDistanceToPlayer;

    void Update()
    {
        this.transform.localPosition += this.transform.localRotation * Vector3.forward * this.speed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        this.ticksSinceRemoveCheck++;
        if (this.ticksSinceRemoveCheck >= TicksUntilRemoveCheck)
        {
            var distance = Vector3.Distance(this.transform.position, this.playerTransform.position);
            if (distance > this.originalDistanceToPlayer + RemoveOvershootDistance)
            {
                GameObject.Destroy(this.gameObject);
            }
            this.ticksSinceRemoveCheck = 0;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            var takeDamage = collider.gameObject.GetComponent<TakeDamage>();
            if (takeDamage != null)
            {
                if (this.bigRocket)
                    takeDamage.BigRocketDamage();
                else
                    takeDamage.RocketDamage();
            }
            GameObject.Destroy(this.gameObject);
        }
    }
}
