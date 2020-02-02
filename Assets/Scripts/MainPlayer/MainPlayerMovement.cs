using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class MainPlayerMovement : MonoBehaviour
{
    const int NoJumpUnderLegHealth = 30;

    public enum JumpStatus
    {
        None,
        Jumping,
        Falling
    }

    public InputMaster controls;

    public float forwardSpeed = 25f;
    public float moveSpeed = 15f;
    public float jumpVelocity = 10f;
    public float maxShiftSpeed = 1f;

    private Rigidbody rb;

    [Inject]
    private HealthStatus healthStatus;

    private Vector2 movement;
    private JumpStatus jumpStatus = JumpStatus.None;

    void Awake()
    {
        this.controls = new InputMaster();
        this.controls.MainPlayer.Movement.started += ctx => this.movement = ctx.ReadValue<Vector2>();
        this.controls.MainPlayer.Movement.performed += ctx => this.movement = ctx.ReadValue<Vector2>();
        this.controls.MainPlayer.Movement.canceled += ctx => this.movement = ctx.ReadValue<Vector2>();
        this.controls.MainPlayer.Jump.performed += ctx => this.TryJump();
    }

    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (this.jumpStatus == JumpStatus.Jumping)
        {
            this.rb.AddForce(new Vector3(0f, this.jumpVelocity, 0f), ForceMode.Impulse);
            this.jumpStatus = JumpStatus.Falling;
        }

        if (this.jumpStatus == JumpStatus.None)
        {
            var leftShift = (HealthStatus.MaxHealth - this.healthStatus.LeftLeg) * 0.01f * this.maxShiftSpeed;
            var rightShift = (HealthStatus.MaxHealth - this.healthStatus.RightLeg) * 0.01f * this.maxShiftSpeed;
            this.rb.AddForce(new Vector3(this.movement.x + (rightShift - leftShift), 0f, 0f), ForceMode.Impulse);
        }

        this.rb.velocity = new Vector3(this.rb.velocity.x, this.rb.velocity.y, this.forwardSpeed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && this.jumpStatus != JumpStatus.None)
        {
            this.jumpStatus = JumpStatus.None;
        }
    }

    void OnEnable()
    {
        this.controls.Enable();
    }

    void OnDisable()
    {
        this.controls.Disable();
    }

    private void TryJump()
    {
        var healthSufficient = this.healthStatus.LeftLeg > NoJumpUnderLegHealth
            && this.healthStatus.RightLeg > NoJumpUnderLegHealth;

        if (this.jumpStatus == JumpStatus.None && healthSufficient)
        {
            this.jumpStatus = JumpStatus.Jumping;
            this.healthStatus.LeftLeg -= 5;
            this.healthStatus.RightLeg -= 5;
        }
    }
}
