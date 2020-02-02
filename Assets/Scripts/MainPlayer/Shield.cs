using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    private InputMaster controls;

    private Vector2 movement;

    void Awake()
    {
        this.controls = new InputMaster();
        this.controls.MainPlayer.RotateShield.started += ctx => this.movement = ctx.ReadValue<Vector2>();
        this.controls.MainPlayer.RotateShield.performed += ctx => this.movement = ctx.ReadValue<Vector2>();
        this.controls.MainPlayer.RotateShield.canceled += ctx => this.movement = ctx.ReadValue<Vector2>();
    }

    void OnEnable()
    {
        this.controls.Enable();
    }

    void OnDisable()
    {
        this.controls.Disable();
    }
}
