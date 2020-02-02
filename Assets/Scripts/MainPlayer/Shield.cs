using UnityEngine;
using UnityEngine.InputSystem;

public class Shield : MonoBehaviour
{
    private InputMaster controls;

    private Vector2 movement;

    void Awake()
    {
        this.controls = new InputMaster();
    }

    void Update()
    {
        this.RotateShield(this.controls.MainPlayer.RotateShield.ReadValue<Vector2>());
    }

    void OnEnable()
    {
        this.controls.Enable();
    }

    void OnDisable()
    {
        this.controls.Disable();
    }

    private void RotateShield(Vector2 direction)
    {
        var lookPoint = this.transform.position + new Vector3(direction.x, 0f, direction.y);
        this.transform.LookAt(lookPoint);
    }
}
