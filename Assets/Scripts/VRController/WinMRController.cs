using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class WinMRController : MonoBehaviour
{
    public enum LeftRight
    {
        Left, Right
    }

    private InputMaster controls;
    [SerializeField] private LeftRight leftRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateControllerPosition();
    }

    void Awake()
    {
        this.controls = new InputMaster();
        Application.onBeforeRender += this.updateControllerPosition;
    }
    void OnEnable()
    {
        this.controls.Enable();
    }

    void OnDisable()
    {
        this.controls.Disable();
    }

    void updateControllerPosition()
    {
        switch (leftRight)
        {
            case LeftRight.Left:
                this.transform.localRotation = this.controls.VRPlayer.LeftRotation.ReadValue<Quaternion>();
                this.transform.localPosition = this.controls.VRPlayer.LeftPosition.ReadValue<Vector3>();
                break;
            case LeftRight.Right:
                this.transform.localRotation = this.controls.VRPlayer.RightRotation.ReadValue<Quaternion>();
                this.transform.localPosition = this.controls.VRPlayer.RightPosition.ReadValue<Vector3>();
                break;
        }
    }
}
