//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputSystem/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Option_1"",
            ""id"": ""e18a303d-70ab-4462-beb2-b19cb2393ffe"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""12321cb4-107d-48cc-945e-43b9fb7fbcdd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Tab"",
                    ""type"": ""Button"",
                    ""id"": ""e3594b5f-b059-40d1-9375-ff682370ddc9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a3c8f79e-b0f9-481c-bb3a-a433541e3d36"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6532e378-845b-4301-84d1-0a0b55f25cf5"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""516efb29-158f-4f3c-b132-216aaf9781ec"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80e000ee-72c7-4215-8e11-17e9b3dbc9b1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23034021-8267-492f-9695-e903aae34f90"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81510b79-635e-4f7d-8f6e-7b0aa7f2beda"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa480cce-3189-4ad8-9647-588810428b47"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52437436-a58e-4e0e-b15d-457b50e5d774"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Option_2"",
            ""id"": ""6283c712-37ba-4748-9b96-651f48ace130"",
            ""actions"": [
                {
                    ""name"": ""MoveAndRotate"",
                    ""type"": ""Value"",
                    ""id"": ""d0570954-952f-42c3-8c60-bdd3f3c3137d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Stoping"",
                    ""type"": ""Button"",
                    ""id"": ""f8f93e34-5648-4276-a160-266519cd2c5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1a410f68-7bb4-48f5-9010-541749409c37"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAndRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""41439982-5cb3-48eb-8389-e01654f2f7a2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAndRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""56664b32-1705-4f74-8bc0-e2f141b0c2c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAndRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""06599ee2-5ed3-43a8-b1ae-b74f6af141db"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAndRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4e951933-2aeb-4b1d-997d-d1c4fe09f844"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAndRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5be275c2-ba67-4fc8-8d31-4f1965b1c056"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAndRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e87c0836-2302-444b-a252-cd49b3d5f153"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stoping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bcbe613-e623-4ca6-ba9c-65540a90c8b3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stoping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca3b4bac-1754-4322-88de-54e8eaa6843d"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stoping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Option_3"",
            ""id"": ""b19e704f-76ba-4499-b92b-e20efaa0f2c7"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7ef2e342-4266-4262-a52e-a7fd3f066cd2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""2660bd6a-48c0-4165-85c9-23eb6812d5f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""63cfcd00-6182-4ce7-99d6-083609d5a438"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""962c7f73-184e-4ee1-a36e-47ad93094df4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""ceb5dd02-95c3-4aa8-9a54-11bdf11118c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponUp"",
                    ""type"": ""Button"",
                    ""id"": ""75ec9afe-47e0-41df-912d-b6cf12a6a983"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd26067f-3cf6-425c-ba2b-5e23bf048f5b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""59011d67-3878-4d74-813f-bfa6c40efd9b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""834e35d0-3e17-4169-821a-d40a310b9344"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""40fc0dfc-71a6-457d-9f26-9ca6409525c5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""45520880-1d62-42e9-9251-fcc905293770"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""916f11b0-8cbb-4bff-b39a-a7a955cff4f8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6748e134-6cf9-4265-89a7-a1fdcf854f22"",
                    ""path"": ""<AndroidJoystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a587ef88-4939-43cb-b1d0-911d0c4840ec"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3eed7fd-858b-49db-93c7-ed560eb58bc5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""256d9336-df74-4660-bfce-50590b3bbcbb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0df0554b-2c95-4b16-ac87-27f1f2091ecb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb0aad0f-5907-46d1-8b09-48e40bc5d3d3"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3480809c-7625-4069-a0eb-5bfd124ef630"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61bdf092-4e16-4799-b5c6-5ce12dd89fbc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1772dd98-858b-4ce6-a705-da810837ab3a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2e313fa-978c-42b3-bccf-852f2599a3e5"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d41d260a-dedf-4cc4-84bb-2353226e3024"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e3ff5a3-508e-4e47-975f-10f07b3bbc24"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Option_1
        m_Option_1 = asset.FindActionMap("Option_1", throwIfNotFound: true);
        m_Option_1_Position = m_Option_1.FindAction("Position", throwIfNotFound: true);
        m_Option_1_Tab = m_Option_1.FindAction("Tab", throwIfNotFound: true);
        // Option_2
        m_Option_2 = asset.FindActionMap("Option_2", throwIfNotFound: true);
        m_Option_2_MoveAndRotate = m_Option_2.FindAction("MoveAndRotate", throwIfNotFound: true);
        m_Option_2_Stoping = m_Option_2.FindAction("Stoping", throwIfNotFound: true);
        // Option_3
        m_Option_3 = asset.FindActionMap("Option_3", throwIfNotFound: true);
        m_Option_3_Move = m_Option_3.FindAction("Move", throwIfNotFound: true);
        m_Option_3_Sprint = m_Option_3.FindAction("Sprint", throwIfNotFound: true);
        m_Option_3_Rotate = m_Option_3.FindAction("Rotate", throwIfNotFound: true);
        m_Option_3_Jump = m_Option_3.FindAction("Jump", throwIfNotFound: true);
        m_Option_3_Shoot = m_Option_3.FindAction("Shoot", throwIfNotFound: true);
        m_Option_3_WeaponUp = m_Option_3.FindAction("WeaponUp", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Option_1
    private readonly InputActionMap m_Option_1;
    private IOption_1Actions m_Option_1ActionsCallbackInterface;
    private readonly InputAction m_Option_1_Position;
    private readonly InputAction m_Option_1_Tab;
    public struct Option_1Actions
    {
        private @Controls m_Wrapper;
        public Option_1Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_Option_1_Position;
        public InputAction @Tab => m_Wrapper.m_Option_1_Tab;
        public InputActionMap Get() { return m_Wrapper.m_Option_1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Option_1Actions set) { return set.Get(); }
        public void SetCallbacks(IOption_1Actions instance)
        {
            if (m_Wrapper.m_Option_1ActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_Option_1ActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_Option_1ActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_Option_1ActionsCallbackInterface.OnPosition;
                @Tab.started -= m_Wrapper.m_Option_1ActionsCallbackInterface.OnTab;
                @Tab.performed -= m_Wrapper.m_Option_1ActionsCallbackInterface.OnTab;
                @Tab.canceled -= m_Wrapper.m_Option_1ActionsCallbackInterface.OnTab;
            }
            m_Wrapper.m_Option_1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Tab.started += instance.OnTab;
                @Tab.performed += instance.OnTab;
                @Tab.canceled += instance.OnTab;
            }
        }
    }
    public Option_1Actions @Option_1 => new Option_1Actions(this);

    // Option_2
    private readonly InputActionMap m_Option_2;
    private IOption_2Actions m_Option_2ActionsCallbackInterface;
    private readonly InputAction m_Option_2_MoveAndRotate;
    private readonly InputAction m_Option_2_Stoping;
    public struct Option_2Actions
    {
        private @Controls m_Wrapper;
        public Option_2Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveAndRotate => m_Wrapper.m_Option_2_MoveAndRotate;
        public InputAction @Stoping => m_Wrapper.m_Option_2_Stoping;
        public InputActionMap Get() { return m_Wrapper.m_Option_2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Option_2Actions set) { return set.Get(); }
        public void SetCallbacks(IOption_2Actions instance)
        {
            if (m_Wrapper.m_Option_2ActionsCallbackInterface != null)
            {
                @MoveAndRotate.started -= m_Wrapper.m_Option_2ActionsCallbackInterface.OnMoveAndRotate;
                @MoveAndRotate.performed -= m_Wrapper.m_Option_2ActionsCallbackInterface.OnMoveAndRotate;
                @MoveAndRotate.canceled -= m_Wrapper.m_Option_2ActionsCallbackInterface.OnMoveAndRotate;
                @Stoping.started -= m_Wrapper.m_Option_2ActionsCallbackInterface.OnStoping;
                @Stoping.performed -= m_Wrapper.m_Option_2ActionsCallbackInterface.OnStoping;
                @Stoping.canceled -= m_Wrapper.m_Option_2ActionsCallbackInterface.OnStoping;
            }
            m_Wrapper.m_Option_2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveAndRotate.started += instance.OnMoveAndRotate;
                @MoveAndRotate.performed += instance.OnMoveAndRotate;
                @MoveAndRotate.canceled += instance.OnMoveAndRotate;
                @Stoping.started += instance.OnStoping;
                @Stoping.performed += instance.OnStoping;
                @Stoping.canceled += instance.OnStoping;
            }
        }
    }
    public Option_2Actions @Option_2 => new Option_2Actions(this);

    // Option_3
    private readonly InputActionMap m_Option_3;
    private IOption_3Actions m_Option_3ActionsCallbackInterface;
    private readonly InputAction m_Option_3_Move;
    private readonly InputAction m_Option_3_Sprint;
    private readonly InputAction m_Option_3_Rotate;
    private readonly InputAction m_Option_3_Jump;
    private readonly InputAction m_Option_3_Shoot;
    private readonly InputAction m_Option_3_WeaponUp;
    public struct Option_3Actions
    {
        private @Controls m_Wrapper;
        public Option_3Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Option_3_Move;
        public InputAction @Sprint => m_Wrapper.m_Option_3_Sprint;
        public InputAction @Rotate => m_Wrapper.m_Option_3_Rotate;
        public InputAction @Jump => m_Wrapper.m_Option_3_Jump;
        public InputAction @Shoot => m_Wrapper.m_Option_3_Shoot;
        public InputAction @WeaponUp => m_Wrapper.m_Option_3_WeaponUp;
        public InputActionMap Get() { return m_Wrapper.m_Option_3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Option_3Actions set) { return set.Get(); }
        public void SetCallbacks(IOption_3Actions instance)
        {
            if (m_Wrapper.m_Option_3ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnMove;
                @Sprint.started -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnSprint;
                @Rotate.started -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnRotate;
                @Jump.started -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnShoot;
                @WeaponUp.started -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnWeaponUp;
                @WeaponUp.performed -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnWeaponUp;
                @WeaponUp.canceled -= m_Wrapper.m_Option_3ActionsCallbackInterface.OnWeaponUp;
            }
            m_Wrapper.m_Option_3ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @WeaponUp.started += instance.OnWeaponUp;
                @WeaponUp.performed += instance.OnWeaponUp;
                @WeaponUp.canceled += instance.OnWeaponUp;
            }
        }
    }
    public Option_3Actions @Option_3 => new Option_3Actions(this);
    public interface IOption_1Actions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnTab(InputAction.CallbackContext context);
    }
    public interface IOption_2Actions
    {
        void OnMoveAndRotate(InputAction.CallbackContext context);
        void OnStoping(InputAction.CallbackContext context);
    }
    public interface IOption_3Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnWeaponUp(InputAction.CallbackContext context);
    }
}