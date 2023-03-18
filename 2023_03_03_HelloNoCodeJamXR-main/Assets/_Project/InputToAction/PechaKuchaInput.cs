//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/_Project/InputToAction/PechaKuchaInput.inputactions
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

public partial class @PechaKuchaInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PechaKuchaInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PechaKuchaInput"",
    ""maps"": [
        {
            ""name"": ""ClassicInput"",
            ""id"": ""ebd16d04-74d6-4310-88cb-bcba16db62ab"",
            ""actions"": [
                {
                    ""name"": ""ResetAndPlay"",
                    ""type"": ""Button"",
                    ""id"": ""27cafc8b-3aa7-444c-aef3-3fbe5cc085be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ResetAndStop"",
                    ""type"": ""Button"",
                    ""id"": ""7a748a3e-a8d9-4c36-950f-237b5bac2252"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NextSlide"",
                    ""type"": ""Button"",
                    ""id"": ""f8318faa-daf3-47a3-9657-d07581104e3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PreviousSlide"",
                    ""type"": ""Button"",
                    ""id"": ""88c25748-8127-49d0-8c44-e3676c744728"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchPause"",
                    ""type"": ""Button"",
                    ""id"": ""e331ac6a-870c-4343-9b5e-21e184922e56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7d292270-a347-427e-8dde-0c0c8d97aa5e"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetAndPlay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""401a441e-db2d-49bb-b9a2-4f2ead95664e"",
                    ""path"": ""<Keyboard>/delete"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetAndPlay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""760e2f42-c410-4d67-85c0-bc899709732e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetAndStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea483c49-933e-4053-81be-eb9b0a6b3e0d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextSlide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ef9bc72-0af6-4d9d-b68e-bf166d22ba05"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextSlide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd94ded8-b753-41e0-8ce8-40026c7a7b26"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousSlide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17e477f6-45b9-4df4-9afc-098af5fb2b48"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousSlide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a37cbf55-f29d-4acb-bea0-bf76add99a2c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04bc91b8-e5d8-4539-b743-343b0f73a767"",
                    ""path"": ""<XRController>{LeftHand}/thumbstickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ClassicInput
        m_ClassicInput = asset.FindActionMap("ClassicInput", throwIfNotFound: true);
        m_ClassicInput_ResetAndPlay = m_ClassicInput.FindAction("ResetAndPlay", throwIfNotFound: true);
        m_ClassicInput_ResetAndStop = m_ClassicInput.FindAction("ResetAndStop", throwIfNotFound: true);
        m_ClassicInput_NextSlide = m_ClassicInput.FindAction("NextSlide", throwIfNotFound: true);
        m_ClassicInput_PreviousSlide = m_ClassicInput.FindAction("PreviousSlide", throwIfNotFound: true);
        m_ClassicInput_SwitchPause = m_ClassicInput.FindAction("SwitchPause", throwIfNotFound: true);
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

    // ClassicInput
    private readonly InputActionMap m_ClassicInput;
    private List<IClassicInputActions> m_ClassicInputActionsCallbackInterfaces = new List<IClassicInputActions>();
    private readonly InputAction m_ClassicInput_ResetAndPlay;
    private readonly InputAction m_ClassicInput_ResetAndStop;
    private readonly InputAction m_ClassicInput_NextSlide;
    private readonly InputAction m_ClassicInput_PreviousSlide;
    private readonly InputAction m_ClassicInput_SwitchPause;
    public struct ClassicInputActions
    {
        private @PechaKuchaInput m_Wrapper;
        public ClassicInputActions(@PechaKuchaInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ResetAndPlay => m_Wrapper.m_ClassicInput_ResetAndPlay;
        public InputAction @ResetAndStop => m_Wrapper.m_ClassicInput_ResetAndStop;
        public InputAction @NextSlide => m_Wrapper.m_ClassicInput_NextSlide;
        public InputAction @PreviousSlide => m_Wrapper.m_ClassicInput_PreviousSlide;
        public InputAction @SwitchPause => m_Wrapper.m_ClassicInput_SwitchPause;
        public InputActionMap Get() { return m_Wrapper.m_ClassicInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClassicInputActions set) { return set.Get(); }
        public void AddCallbacks(IClassicInputActions instance)
        {
            if (instance == null || m_Wrapper.m_ClassicInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ClassicInputActionsCallbackInterfaces.Add(instance);
            @ResetAndPlay.started += instance.OnResetAndPlay;
            @ResetAndPlay.performed += instance.OnResetAndPlay;
            @ResetAndPlay.canceled += instance.OnResetAndPlay;
            @ResetAndStop.started += instance.OnResetAndStop;
            @ResetAndStop.performed += instance.OnResetAndStop;
            @ResetAndStop.canceled += instance.OnResetAndStop;
            @NextSlide.started += instance.OnNextSlide;
            @NextSlide.performed += instance.OnNextSlide;
            @NextSlide.canceled += instance.OnNextSlide;
            @PreviousSlide.started += instance.OnPreviousSlide;
            @PreviousSlide.performed += instance.OnPreviousSlide;
            @PreviousSlide.canceled += instance.OnPreviousSlide;
            @SwitchPause.started += instance.OnSwitchPause;
            @SwitchPause.performed += instance.OnSwitchPause;
            @SwitchPause.canceled += instance.OnSwitchPause;
        }

        private void UnregisterCallbacks(IClassicInputActions instance)
        {
            @ResetAndPlay.started -= instance.OnResetAndPlay;
            @ResetAndPlay.performed -= instance.OnResetAndPlay;
            @ResetAndPlay.canceled -= instance.OnResetAndPlay;
            @ResetAndStop.started -= instance.OnResetAndStop;
            @ResetAndStop.performed -= instance.OnResetAndStop;
            @ResetAndStop.canceled -= instance.OnResetAndStop;
            @NextSlide.started -= instance.OnNextSlide;
            @NextSlide.performed -= instance.OnNextSlide;
            @NextSlide.canceled -= instance.OnNextSlide;
            @PreviousSlide.started -= instance.OnPreviousSlide;
            @PreviousSlide.performed -= instance.OnPreviousSlide;
            @PreviousSlide.canceled -= instance.OnPreviousSlide;
            @SwitchPause.started -= instance.OnSwitchPause;
            @SwitchPause.performed -= instance.OnSwitchPause;
            @SwitchPause.canceled -= instance.OnSwitchPause;
        }

        public void RemoveCallbacks(IClassicInputActions instance)
        {
            if (m_Wrapper.m_ClassicInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IClassicInputActions instance)
        {
            foreach (var item in m_Wrapper.m_ClassicInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ClassicInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ClassicInputActions @ClassicInput => new ClassicInputActions(this);
    public interface IClassicInputActions
    {
        void OnResetAndPlay(InputAction.CallbackContext context);
        void OnResetAndStop(InputAction.CallbackContext context);
        void OnNextSlide(InputAction.CallbackContext context);
        void OnPreviousSlide(InputAction.CallbackContext context);
        void OnSwitchPause(InputAction.CallbackContext context);
    }
}