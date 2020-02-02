using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(MeshRenderer))]
public class TriggerController : MonoBehaviour
{
    public enum LeftRight
    {
        Left, Right
    }

    private InputMaster controls;
    public Material testMaterial;
    public Material testMaterial2;
    private MeshRenderer meshRenderer;
    [SerializeField] private LeftRight leftRight;

    // Start is called before the first frame update
    void Start()
    {
        this.meshRenderer = this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.updateTrigger();
    }

    void Awake()
    {
        this.controls = new InputMaster();
        //this.controls.VRPlayer.TriggerLeft.performed += ctx => this.DoSomething(ctx.ReadValue<float>());
        Application.onBeforeRender += this.updateTrigger;
    }

    void OnEnable()
    {
        this.controls.Enable();
    }

    void OnDisable()
    {
        this.controls.Disable();
    }

    void updateTrigger()
    {
        float value = 0;
        switch (leftRight)
        {
            case LeftRight.Left:
                value = this.controls.VRPlayer.TriggerLeft.ReadValue<float>();
                break;
            case LeftRight.Right:
                value = this.controls.VRPlayer.TriggerRight.ReadValue<float>();
                break;
        }

        if (value >= 0.8)
        {
            this.meshRenderer.material = testMaterial;
        } else
        {
            this.meshRenderer.material = testMaterial2;
        }
    }
}
