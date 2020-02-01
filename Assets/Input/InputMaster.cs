// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""MainPlayer"",
            ""id"": ""a6ea3eac-0c5a-4842-9aac-70c6a4ccaa79"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""7aaa9120-c9fa-43d4-aed7-92966d0978c2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4407e48b-aa63-4525-848e-b270e38cb066"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Button"",
                    ""id"": ""d5c73c2d-e755-4c53-915f-6ee52758b8e2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""cce5b003-26d3-49ab-9b16-974194cedf02"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1c20bb3-9cbc-43a4-807c-f182a0d71128"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a5e28f0c-3044-41e4-b2cb-b0bc8b2a80ef"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6c98e2c7-1a48-4010-a3d3-8a0c13dde137"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""53cab6cb-a40c-4476-804f-2315ead4220f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""560df547-1fcf-411f-b17e-c952b27a070e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9d002ba3-c436-4421-a4d0-3a88789ebe69"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""45fa19b8-35dd-43c9-8d21-bc307f592836"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2c15d55b-04e6-4c3b-a9f1-8d3afa50905f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5a5d9e62-b8e1-4f1a-b679-9c681f9d2a7e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""294b8aa6-ffb3-405c-be1e-d87d467e18ce"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f2e90882-ad4d-40b4-a097-d9a41b41d4ae"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""23fb62dc-2061-42d0-a45e-cc839b4eaa5e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""85d72f50-58d8-4ee2-a438-591cd66b00d5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1cc60563-4f91-4f0b-9e75-17836b625981"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""3d4db234-9325-4d72-b73f-2f4accad5aec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a7ad045f-95dd-489e-a12d-05d134d89809"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f0170d5b-8a75-48b7-8801-eae78a2089dd"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""42edd642-6b25-4274-84b5-e68fc885a97d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""847b0f65-74e8-45a9-8544-349f97be7c85"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9f308882-fbea-490f-b3a8-e362232a2d43"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""845dec90-2121-44f5-b0f6-8abebf85b0c4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Q/E"",
                    ""id"": ""814e4a28-ebeb-4d77-88f1-7133da13848a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b7f6a2d0-bb0d-43f3-a287-2c9309716d81"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""58e1f660-4162-40fd-93a6-0f81eb9ae5b6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shoulders"",
                    ""id"": ""a5fa85a0-d8d6-455d-851a-6dfb9e5712ea"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6b44e4eb-fbc9-4f52-85df-9e6c76b6611c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9ccd63ea-0d9f-4293-8dd1-50898d42382f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""VRPlayer"",
            ""id"": ""e6aaaae2-b461-485d-9bb4-92d268fa34d0"",
            ""actions"": [
                {
                    ""name"": ""TriggerRight"",
                    ""type"": ""Value"",
                    ""id"": ""b2150969-83b8-48c7-bc8e-03b34e7f87d9"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerLeft"",
                    ""type"": ""Value"",
                    ""id"": ""772aa349-0738-404b-b37c-34847b03d2a4"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftPosition"",
                    ""type"": ""Button"",
                    ""id"": ""a1e93b21-43b9-4d4c-9c55-f486fbde98bb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftRotation"",
                    ""type"": ""Button"",
                    ""id"": ""eef00d9d-555f-471b-80d5-642e4ded4aac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightPosition"",
                    ""type"": ""Button"",
                    ""id"": ""fe59944a-7134-4165-9eea-41662e53fc2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightRotation"",
                    ""type"": ""Value"",
                    ""id"": ""3364ad72-e2a5-46d4-8899-0d3128bf5926"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b8db92d0-ddf6-4836-82f2-877946480083"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74137842-09b1-4862-95ba-032d9a36b8da"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba7c87c2-61e0-4c7e-a4cd-a81b1e9cc119"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a0f1dc6-f7eb-4411-9566-ba827534389e"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""006d31c1-e130-40f5-b544-29f3e0d0624c"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32b3a018-17d8-4611-9eb2-c526e4cd07cf"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MainPlayer
        m_MainPlayer = asset.FindActionMap("MainPlayer", throwIfNotFound: true);
        m_MainPlayer_Movement = m_MainPlayer.FindAction("Movement", throwIfNotFound: true);
        m_MainPlayer_Jump = m_MainPlayer.FindAction("Jump", throwIfNotFound: true);
        m_MainPlayer_RotateCamera = m_MainPlayer.FindAction("RotateCamera", throwIfNotFound: true);
        // VRPlayer
        m_VRPlayer = asset.FindActionMap("VRPlayer", throwIfNotFound: true);
        m_VRPlayer_TriggerRight = m_VRPlayer.FindAction("TriggerRight", throwIfNotFound: true);
        m_VRPlayer_TriggerLeft = m_VRPlayer.FindAction("TriggerLeft", throwIfNotFound: true);
        m_VRPlayer_LeftPosition = m_VRPlayer.FindAction("LeftPosition", throwIfNotFound: true);
        m_VRPlayer_LeftRotation = m_VRPlayer.FindAction("LeftRotation", throwIfNotFound: true);
        m_VRPlayer_RightPosition = m_VRPlayer.FindAction("RightPosition", throwIfNotFound: true);
        m_VRPlayer_RightRotation = m_VRPlayer.FindAction("RightRotation", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // MainPlayer
    private readonly InputActionMap m_MainPlayer;
    private IMainPlayerActions m_MainPlayerActionsCallbackInterface;
    private readonly InputAction m_MainPlayer_Movement;
    private readonly InputAction m_MainPlayer_Jump;
    private readonly InputAction m_MainPlayer_RotateCamera;
    public struct MainPlayerActions
    {
        private @InputMaster m_Wrapper;
        public MainPlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MainPlayer_Movement;
        public InputAction @Jump => m_Wrapper.m_MainPlayer_Jump;
        public InputAction @RotateCamera => m_Wrapper.m_MainPlayer_RotateCamera;
        public InputActionMap Get() { return m_Wrapper.m_MainPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IMainPlayerActions instance)
        {
            if (m_Wrapper.m_MainPlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnJump;
                @RotateCamera.started -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_MainPlayerActionsCallbackInterface.OnRotateCamera;
            }
            m_Wrapper.m_MainPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
            }
        }
    }
    public MainPlayerActions @MainPlayer => new MainPlayerActions(this);

    // VRPlayer
    private readonly InputActionMap m_VRPlayer;
    private IVRPlayerActions m_VRPlayerActionsCallbackInterface;
    private readonly InputAction m_VRPlayer_TriggerRight;
    private readonly InputAction m_VRPlayer_TriggerLeft;
    private readonly InputAction m_VRPlayer_LeftPosition;
    private readonly InputAction m_VRPlayer_LeftRotation;
    private readonly InputAction m_VRPlayer_RightPosition;
    private readonly InputAction m_VRPlayer_RightRotation;
    public struct VRPlayerActions
    {
        private @InputMaster m_Wrapper;
        public VRPlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @TriggerRight => m_Wrapper.m_VRPlayer_TriggerRight;
        public InputAction @TriggerLeft => m_Wrapper.m_VRPlayer_TriggerLeft;
        public InputAction @LeftPosition => m_Wrapper.m_VRPlayer_LeftPosition;
        public InputAction @LeftRotation => m_Wrapper.m_VRPlayer_LeftRotation;
        public InputAction @RightPosition => m_Wrapper.m_VRPlayer_RightPosition;
        public InputAction @RightRotation => m_Wrapper.m_VRPlayer_RightRotation;
        public InputActionMap Get() { return m_Wrapper.m_VRPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VRPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IVRPlayerActions instance)
        {
            if (m_Wrapper.m_VRPlayerActionsCallbackInterface != null)
            {
                @TriggerRight.started -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnTriggerRight;
                @TriggerRight.performed -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnTriggerRight;
                @TriggerRight.canceled -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnTriggerRight;
                @TriggerLeft.started -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnTriggerLeft;
                @TriggerLeft.performed -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnTriggerLeft;
                @TriggerLeft.canceled -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnTriggerLeft;
                @LeftPosition.started -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnLeftPosition;
                @LeftPosition.performed -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnLeftPosition;
                @LeftPosition.canceled -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnLeftPosition;
                @LeftRotation.started -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnLeftRotation;
                @LeftRotation.performed -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnLeftRotation;
                @LeftRotation.canceled -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnLeftRotation;
                @RightPosition.started -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnRightPosition;
                @RightPosition.performed -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnRightPosition;
                @RightPosition.canceled -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnRightPosition;
                @RightRotation.started -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnRightRotation;
                @RightRotation.performed -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnRightRotation;
                @RightRotation.canceled -= m_Wrapper.m_VRPlayerActionsCallbackInterface.OnRightRotation;
            }
            m_Wrapper.m_VRPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TriggerRight.started += instance.OnTriggerRight;
                @TriggerRight.performed += instance.OnTriggerRight;
                @TriggerRight.canceled += instance.OnTriggerRight;
                @TriggerLeft.started += instance.OnTriggerLeft;
                @TriggerLeft.performed += instance.OnTriggerLeft;
                @TriggerLeft.canceled += instance.OnTriggerLeft;
                @LeftPosition.started += instance.OnLeftPosition;
                @LeftPosition.performed += instance.OnLeftPosition;
                @LeftPosition.canceled += instance.OnLeftPosition;
                @LeftRotation.started += instance.OnLeftRotation;
                @LeftRotation.performed += instance.OnLeftRotation;
                @LeftRotation.canceled += instance.OnLeftRotation;
                @RightPosition.started += instance.OnRightPosition;
                @RightPosition.performed += instance.OnRightPosition;
                @RightPosition.canceled += instance.OnRightPosition;
                @RightRotation.started += instance.OnRightRotation;
                @RightRotation.performed += instance.OnRightRotation;
                @RightRotation.canceled += instance.OnRightRotation;
            }
        }
    }
    public VRPlayerActions @VRPlayer => new VRPlayerActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMainPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
    }
    public interface IVRPlayerActions
    {
        void OnTriggerRight(InputAction.CallbackContext context);
        void OnTriggerLeft(InputAction.CallbackContext context);
        void OnLeftPosition(InputAction.CallbackContext context);
        void OnLeftRotation(InputAction.CallbackContext context);
        void OnRightPosition(InputAction.CallbackContext context);
        void OnRightRotation(InputAction.CallbackContext context);
    }
}
