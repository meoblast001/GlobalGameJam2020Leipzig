using UnityEngine;
using UnityEngine.InputSystem;

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

    public float moveSpeed = 3f;
    public float jumpVelocity = 20f;

    private Rigidbody rb;
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
        var jumpVelocity = 0f;
        if (this.jumpStatus == JumpStatus.Jumping)
        {
            jumpVelocity = this.jumpVelocity;
            this.jumpStatus = JumpStatus.Falling;
        }
        this.rb.velocity = new Vector3(this.movement.x, jumpVelocity, 0f) * this.moveSpeed;
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
