using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotate : MonoBehaviour
{
    public InputMaster controls;

    private float rotation = 0f;

    void Awake()
    {
        this.controls = new InputMaster();
        this.controls.MainPlayer.RotateCamera.started += ctx => this.rotation = ctx.ReadValue<float>();
        this.controls.MainPlayer.RotateCamera.performed += ctx => this.rotation = ctx.ReadValue<float>();
        this.controls.MainPlayer.RotateCamera.canceled += ctx => this.rotation = ctx.ReadValue<float>();
    }

    void Update()
    {
        var eulers = this.transform.rotation.eulerAngles;
        eulers.y = Mathf.Repeat(eulers.y + this.rotation, 360);
        eulers.y = eulers.y > 45f && eulers.y <= 180f ? 45f : eulers.y;
        eulers.y = eulers.y >= 180f && eulers.y < 315f ? 315f : eulers.y;
        this.transform.rotation = Quaternion.Euler(eulers.x, eulers.y, eulers.z);
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
