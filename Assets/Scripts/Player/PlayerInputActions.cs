//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""4664719f-4587-40b2-8d08-eef2ed755b67"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""90f11a09-58e8-4e16-b453-27b45ae24406"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Player1"",
                    ""id"": ""98e36e78-484f-4214-b9df-41ac406f2db7"",
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
                    ""id"": ""3683f936-c7d6-4cdd-a58e-e401b0b9f16c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""60274af5-7c82-451b-90d6-2b6195be9738"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6058e1c3-97d7-4d95-b5d1-47c9e95d7a24"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""63e94823-548f-4260-b10c-3934c1405929"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""620b9a01-49ca-4229-a41e-25146475f74f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3f1c2438-35f4-4198-8a11-fed8904269b7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Player2"",
                    ""id"": ""9948db2f-d326-48a0-b04e-83af7fa4c78e"",
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
                    ""id"": ""0b4216ce-c59c-494e-9eb3-e02e132f5e73"",
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
                    ""id"": ""0e1cb606-d79e-426a-b877-a6ed8d4c9665"",
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
                    ""id"": ""789337d0-260b-4e97-81a6-57f43afd1bb6"",
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
                    ""id"": ""0b732c22-d255-473b-97e2-649005c275ac"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player3"",
            ""id"": ""05ede376-10a5-4b4f-8e00-bc534e5b313a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4a0ec970-1bde-407f-a206-c0095c90b351"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Player3"",
                    ""id"": ""78dc988d-e4ab-4517-8510-01921f2da23a"",
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
                    ""id"": ""dd322cf6-b1cf-4c3b-90ee-1d28245fdab6"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ab89a72e-f71b-43ce-8f0b-10ac3865722b"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""93215521-2ede-4c4a-acf2-713eee2a0039"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cfd871e4-f445-4e63-98b8-d2153d559410"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player4"",
            ""id"": ""244c4bf1-18f6-40db-9eb6-9c9c570397c8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""74516aeb-bf9a-4199-99d8-7742ff3eeef9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Player4"",
                    ""id"": ""e92b24d7-ccbc-4887-866a-391adbda414f"",
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
                    ""id"": ""abef77bb-a414-481f-a07b-be544a83090f"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""65cca1ed-d104-4e7b-a774-9d2eedff10c4"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3d95eb8d-4e9b-44c4-8b3d-4c819476c6dc"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""98091e93-c1fb-4ba7-b625-6c1582ce2374"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Move = m_Player1.FindAction("Move", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Move = m_Player2.FindAction("Move", throwIfNotFound: true);
        // Player3
        m_Player3 = asset.FindActionMap("Player3", throwIfNotFound: true);
        m_Player3_Move = m_Player3.FindAction("Move", throwIfNotFound: true);
        // Player4
        m_Player4 = asset.FindActionMap("Player4", throwIfNotFound: true);
        m_Player4_Move = m_Player4.FindAction("Move", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private List<IPlayer1Actions> m_Player1ActionsCallbackInterfaces = new List<IPlayer1Actions>();
    private readonly InputAction m_Player1_Move;
    public struct Player1Actions
    {
        private @PlayerInputActions m_Wrapper;
        public Player1Actions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer1Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player1ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayer1Actions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer1Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player1ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private List<IPlayer2Actions> m_Player2ActionsCallbackInterfaces = new List<IPlayer2Actions>();
    private readonly InputAction m_Player2_Move;
    public struct Player2Actions
    {
        private @PlayerInputActions m_Wrapper;
        public Player2Actions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player2_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer2Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player2ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player2ActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayer2Actions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer2Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player2ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player2ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // Player3
    private readonly InputActionMap m_Player3;
    private List<IPlayer3Actions> m_Player3ActionsCallbackInterfaces = new List<IPlayer3Actions>();
    private readonly InputAction m_Player3_Move;
    public struct Player3Actions
    {
        private @PlayerInputActions m_Wrapper;
        public Player3Actions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player3_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player3Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer3Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player3ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player3ActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayer3Actions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayer3Actions instance)
        {
            if (m_Wrapper.m_Player3ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer3Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player3ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player3ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player3Actions @Player3 => new Player3Actions(this);

    // Player4
    private readonly InputActionMap m_Player4;
    private List<IPlayer4Actions> m_Player4ActionsCallbackInterfaces = new List<IPlayer4Actions>();
    private readonly InputAction m_Player4_Move;
    public struct Player4Actions
    {
        private @PlayerInputActions m_Wrapper;
        public Player4Actions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player4_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player4Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer4Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player4ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player4ActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayer4Actions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayer4Actions instance)
        {
            if (m_Wrapper.m_Player4ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer4Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player4ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player4ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player4Actions @Player4 => new Player4Actions(this);
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer3Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer4Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
