//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Car/Car_Control_Actions/Car_Control_Actions.inputactions
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

public partial class @Car_Control_Actions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Car_Control_Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Car_Control_Actions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""f954c9a7-481b-4c5f-b7e8-bcd5efc5140e"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""0be6c78d-5e30-4364-9ca6-2bc14c571e11"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BrakePedal"",
                    ""type"": ""Value"",
                    ""id"": ""f53e2dce-ce4c-4603-a291-121aba8093d2"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""4c62d5e9-31dd-4f3c-91f1-cde9d6f089a2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""63a8952d-1908-49f5-90da-d92b66de4de8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb1dc09c-f786-42b9-94b2-19bb31a76b46"",
                    ""path"": ""<Joystick>/rz"",
                    ""interactions"": """",
                    ""processors"": ""Invert,Normalize(min=-1,max=1,zero=-1)"",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ab01218-c089-4e93-8f96-c894311f5082"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BrakePedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ee7a8a9-c8a3-433b-bd43-70be5074e278"",
                    ""path"": ""<Joystick>/stick/y"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1,zero=-1)"",
                    ""groups"": """",
                    ""action"": ""BrakePedal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector AD"",
                    ""id"": ""703c091a-1685-40e5-94f7-f9def3c8bdfe"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""94060eca-85fa-4d74-859d-f46ae713bba1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""923eb46a-5bf8-4eae-9965-d46d1e5672b6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7eacc757-ed92-484f-88fc-cdb7929142e8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d3458cde-f683-47e7-8f88-594dcad0fb51"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8fff64c3-0d59-4d7c-a721-89eef1fa6bef"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""425e3465-c77a-40eb-8c92-0e3a32aa64e0"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""f44bb0db-3684-4d53-8e74-a1e84479f3b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85a60eed-0e27-437e-9fa4-34a59dbcea74"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Accelerate = m_Gameplay.FindAction("Accelerate", throwIfNotFound: true);
        m_Gameplay_BrakePedal = m_Gameplay.FindAction("BrakePedal", throwIfNotFound: true);
        m_Gameplay_Turn = m_Gameplay.FindAction("Turn", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Accelerate;
    private readonly InputAction m_Gameplay_BrakePedal;
    private readonly InputAction m_Gameplay_Turn;
    public struct GameplayActions
    {
        private @Car_Control_Actions m_Wrapper;
        public GameplayActions(@Car_Control_Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Gameplay_Accelerate;
        public InputAction @BrakePedal => m_Wrapper.m_Gameplay_BrakePedal;
        public InputAction @Turn => m_Wrapper.m_Gameplay_Turn;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Accelerate.started += instance.OnAccelerate;
            @Accelerate.performed += instance.OnAccelerate;
            @Accelerate.canceled += instance.OnAccelerate;
            @BrakePedal.started += instance.OnBrakePedal;
            @BrakePedal.performed += instance.OnBrakePedal;
            @BrakePedal.canceled += instance.OnBrakePedal;
            @Turn.started += instance.OnTurn;
            @Turn.performed += instance.OnTurn;
            @Turn.canceled += instance.OnTurn;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Accelerate.started -= instance.OnAccelerate;
            @Accelerate.performed -= instance.OnAccelerate;
            @Accelerate.canceled -= instance.OnAccelerate;
            @BrakePedal.started -= instance.OnBrakePedal;
            @BrakePedal.performed -= instance.OnBrakePedal;
            @BrakePedal.canceled -= instance.OnBrakePedal;
            @Turn.started -= instance.OnTurn;
            @Turn.performed -= instance.OnTurn;
            @Turn.canceled -= instance.OnTurn;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @Car_Control_Actions m_Wrapper;
        public UIActions(@Car_Control_Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IGameplayActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnBrakePedal(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
