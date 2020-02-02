using UnityEngine;
using UnityEngine.InputSystem;

public class ShieldContainer : MonoBehaviour
{
    [SerializeField] private GameObject shield;

    private InputMaster controls;

    void Awake()
    {
        Debug.Log("Do something");
        this.controls = new InputMaster();
        this.controls.MainPlayer.Shield.started += ctx => this.ToggleShield(true);
        this.controls.MainPlayer.Shield.canceled += ctx => this.ToggleShield(false);
    }

    void Start()
    {
        this.ToggleShield(false);
    }

    private void ToggleShield(bool enabled)
    {
        this.shield.SetActive(enabled);
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
