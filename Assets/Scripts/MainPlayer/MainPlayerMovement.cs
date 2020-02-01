using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class MainPlayerMovement : MonoBehaviour
{
    public enum JumpStatus
    {
        None,
        Jumping,
        Falling
    }

    public InputMaster controls;

    public float moveSpeed = 2f;
    public float jumpVelocity = 5f;
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

        var leftShift = (HealthStatus.MaxHealth - this.healthStatus.LeftLeg) * 0.01f * this.maxShiftSpeed;
        var rightShift = (HealthStatus.MaxHealth - this.healthStatus.RightLeg) * 0.01f * this.maxShiftSpeed;
        this.rb.AddForce(new Vector3(this.movement.x + (rightShift - leftShift), 0f, 0f), ForceMode.Impulse);
    }

    void OnCollisionStay(Collision collision)
    {
        this.jumpStatus = JumpStatus.None;
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
        if (this.jumpStatus == JumpStatus.None)
            this.jumpStatus = JumpStatus.Jumping;
    }
}
