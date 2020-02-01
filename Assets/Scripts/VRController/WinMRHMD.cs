using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class WinMRHMD : MonoBehaviour
{
    private InputMaster controls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateHMDPosition();
    }

    void Awake()
    {
        this.controls = new InputMaster();
        //this.controls.VRPlayer.VRHead.started += ctx => this.DoSomething(ctx.ReadValue<Quaternion>());
        Application.onBeforeRender += this.updateHMDPosition;
    }

    void OnEnable()
    {
        this.controls.Enable();
    }

    void OnDisable()
    {
        this.controls.Disable();
    }

    void updateHMDPosition()
    {
        var rotationHMD = InputSystem.GetDevice<XRHMD>()?.deviceRotation?.ReadValue();
        if (rotationHMD.HasValue)
        {
            this.transform.localRotation = rotationHMD.Value;
        }

        var positionHMD = InputSystem.GetDevice<XRHMD>()?.devicePosition?.ReadValue();
        if (positionHMD.HasValue)
        {
            this.transform.localPosition = positionHMD.Value;
        }
    }
}
