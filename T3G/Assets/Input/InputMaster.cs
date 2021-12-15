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
            ""name"": ""Player"",
            ""id"": ""815ea9bd-8b04-4ff4-9d07-4ff6e4ad9684"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5d7c527c-0eb0-433b-ba27-ff53c31372fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a65916b3-b93b-47fb-a3f6-5093a68a507e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotate"",
                    ""type"": ""Value"",
                    ""id"": ""e63b28e5-dee3-48b5-9a3d-5a5dd04df359"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pick"",
                    ""type"": ""Button"",
                    ""id"": ""f0b747a5-3eac-4d37-a21f-2223be6a7eda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReturnToPool"",
                    ""type"": ""Button"",
                    ""id"": ""baaa3e15-819b-4887-bf05-03d55c8dc4f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e71aae69-af08-41dc-9db4-6ea62ba13ad4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasdControls"",
                    ""id"": ""e570b38e-1a04-49c3-a96c-62e121c970d1"",
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
                    ""id"": ""0423fd53-39cd-4277-b9e2-bc3bc288b16b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c61f33bf-1b4b-469a-a4fd-e5d3a471dcc7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""79b9894b-dee5-4d9c-b727-9f785f2999ad"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fc4e01ab-e93a-486b-b8f0-0fdce348dbfb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""19765f15-c659-4bbc-a0e0-813b6392d7c3"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""CameraRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8f26863-685a-40f6-8632-135ae792a49f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Pick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ac9b4a4-4ef0-4213-afb7-8ebcedec90fe"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""ReturnToPool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""StateControl"",
            ""id"": ""90f79854-dee3-417d-a156-6219a8028595"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""54a0126b-6e57-4edf-aed4-687335dd91ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""3cf08deb-78bf-4b24-981b-936012044251"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""60dabf10-f74f-4077-82b1-c0f5f1e4f303"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a7d92c6-7318-44a5-81de-f066ed661147"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
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
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_CameraRotate = m_Player.FindAction("CameraRotate", throwIfNotFound: true);
        m_Player_Pick = m_Player.FindAction("Pick", throwIfNotFound: true);
        m_Player_ReturnToPool = m_Player.FindAction("ReturnToPool", throwIfNotFound: true);
        // StateControl
        m_StateControl = asset.FindActionMap("StateControl", throwIfNotFound: true);
        m_StateControl_Pause = m_StateControl.FindAction("Pause", throwIfNotFound: true);
        m_StateControl_Resume = m_StateControl.FindAction("Resume", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_CameraRotate;
    private readonly InputAction m_Player_Pick;
    private readonly InputAction m_Player_ReturnToPool;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @CameraRotate => m_Wrapper.m_Player_CameraRotate;
        public InputAction @Pick => m_Wrapper.m_Player_Pick;
        public InputAction @ReturnToPool => m_Wrapper.m_Player_ReturnToPool;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @CameraRotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotate;
                @CameraRotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotate;
                @CameraRotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotate;
                @Pick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPick;
                @Pick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPick;
                @Pick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPick;
                @ReturnToPool.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReturnToPool;
                @ReturnToPool.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReturnToPool;
                @ReturnToPool.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReturnToPool;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @CameraRotate.started += instance.OnCameraRotate;
                @CameraRotate.performed += instance.OnCameraRotate;
                @CameraRotate.canceled += instance.OnCameraRotate;
                @Pick.started += instance.OnPick;
                @Pick.performed += instance.OnPick;
                @Pick.canceled += instance.OnPick;
                @ReturnToPool.started += instance.OnReturnToPool;
                @ReturnToPool.performed += instance.OnReturnToPool;
                @ReturnToPool.canceled += instance.OnReturnToPool;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // StateControl
    private readonly InputActionMap m_StateControl;
    private IStateControlActions m_StateControlActionsCallbackInterface;
    private readonly InputAction m_StateControl_Pause;
    private readonly InputAction m_StateControl_Resume;
    public struct StateControlActions
    {
        private @InputMaster m_Wrapper;
        public StateControlActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_StateControl_Pause;
        public InputAction @Resume => m_Wrapper.m_StateControl_Resume;
        public InputActionMap Get() { return m_Wrapper.m_StateControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StateControlActions set) { return set.Get(); }
        public void SetCallbacks(IStateControlActions instance)
        {
            if (m_Wrapper.m_StateControlActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_StateControlActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_StateControlActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_StateControlActionsCallbackInterface.OnPause;
                @Resume.started -= m_Wrapper.m_StateControlActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_StateControlActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_StateControlActionsCallbackInterface.OnResume;
            }
            m_Wrapper.m_StateControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
            }
        }
    }
    public StateControlActions @StateControl => new StateControlActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnCameraRotate(InputAction.CallbackContext context);
        void OnPick(InputAction.CallbackContext context);
        void OnReturnToPool(InputAction.CallbackContext context);
    }
    public interface IStateControlActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
    }
}
