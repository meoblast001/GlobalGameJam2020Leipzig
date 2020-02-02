using System;
using UnityEngine;
using Zenject;

public class TakeDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public int rocketDamage = 1;
    public int bigRocketDamage = 50;

    [Inject]
    private HealthStatus healthStatus;

    private System.Random random = new System.Random();

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
        {
            this.TakeRandomDamage(this.collisionDamage);
        }
    }

    public void RocketDamage()
    {
        this.TakeRandomDamage(this.rocketDamage);
    }

    public void BigRocketDamage()
    {
        this.TakeRandomDamage(this.bigRocketDamage);
    }

    private void TakeRandomDamage(int damage)
    {
        var count = Enum.GetNames(typeof(HealthStatus.HealthPart)).Length;
        var item = (HealthStatus.HealthPart) (this.random.Next() % count);
        switch (item)
        {
            case HealthStatus.HealthPart.Screen:
                this.healthStatus.Screen -= damage;
                break;
            case HealthStatus.HealthPart.Hip:
                this.healthStatus.Hip -= damage;
                break;
            case HealthStatus.HealthPart.RightLeg:
                this.healthStatus.RightLeg -= damage;
                break;
            case HealthStatus.HealthPart.LeftLeg:
                this.healthStatus.LeftLeg -= damage;
                break;
            case HealthStatus.HealthPart.Weapon:
                this.healthStatus.Weapon -= damage;
                break;
            case HealthStatus.HealthPart.Shield:
                this.healthStatus.Shield -= damage;
                break;
            default:
                Debug.LogError($"Unknown health status type '{item}'");
                break;
        }
    }
}
