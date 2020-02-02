using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class Shield : MonoBehaviour
{
    public int usageLoseHealth = 5;
    public float usageLoseHealthEverySeconds = 0.5f;
 
    private InputMaster controls;

    [Inject] private HealthStatus healthStatus;

    private Vector2 movement;
    private float usageSeconds;

    void Awake()
    {
        this.controls = new InputMaster();
    }

    void Update()
    {
        this.RotateShield(this.controls.MainPlayer.RotateShield.ReadValue<Vector2>());
        this.usageSeconds += Time.deltaTime;

        while (this.usageSeconds >= this.usageLoseHealthEverySeconds)
        {
            this.healthStatus.Shield -= this.usageLoseHealth;
            this.usageSeconds -= this.usageLoseHealthEverySeconds;
        }
    }

    void OnEnable()
    {
        this.usageSeconds = this.usageLoseHealthEverySeconds;
        this.controls.Enable();
    }

    void OnDisable()
    {
        this.controls.Disable();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rocket>() != null)
            GameObject.Destroy(other);
    }

    private void RotateShield(Vector2 direction)
    {
        var lookPoint = this.transform.position + new Vector3(direction.x, 0f, direction.y);
        this.transform.LookAt(lookPoint);
    }
}
