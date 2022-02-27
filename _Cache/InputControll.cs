// GENERATED AUTOMATICALLY FROM 'Assets/_Cache/InputControll.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControll : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControll()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControll"",
    ""maps"": [
        {
            ""name"": ""Controll"",
            ""id"": ""63326646-5176-4957-a011-cd70cee0e577"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""c6768829-19d6-4af6-98a5-863825226585"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveVertical"",
                    ""type"": ""Button"",
                    ""id"": ""40276b66-9995-4d03-8cc6-0f14970bafd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cc358c29-fc68-4616-a9f0-bdcb19106a10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionE"",
                    ""type"": ""Button"",
                    ""id"": ""86c3bdcd-53be-49e5-968c-ce0d4bd84c4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionS"",
                    ""type"": ""Button"",
                    ""id"": ""00e3541d-afa5-4355-8ee9-7b3980243096"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""bae80b7c-0e9c-4f03-a3ac-91a61b15f79f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""debugChangePlatform"",
                    ""type"": ""Button"",
                    ""id"": ""5fd8f96b-792c-401a-b225-958fe48d435c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseEscape"",
                    ""type"": ""Button"",
                    ""id"": ""249c2eb1-d20d-4daa-b8e6-f068f58b5860"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""026f0559-1697-4291-883a-c94c6953498a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ac51539a-9872-4784-a752-e940777f3405"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""21614663-f4a9-41cf-be5f-096fc640f677"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5826af96-40fc-4693-8661-a93e571f2013"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""22899a54-7158-4ed5-ab93-2417915b4aea"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""071c069a-6fb0-4873-8875-bce44b21ed28"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2cc0092e-c461-4cc0-891e-1f4a8513ec2a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce176068-5b0c-45fb-a754-53fae05cdc9f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eb6db0b-520d-4c07-b062-cb687c47b2fb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""420af1ff-5880-4f33-b275-b0d8d65d4f31"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""ActionE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9acb767e-4b6f-4308-a886-85f3d0334422"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee904428-bc57-402f-89b8-d51e3a2ca8ac"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""ActionS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cacb81e9-0e9c-461f-a17d-b131fedf606a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""af1521d3-2049-459a-8156-e7f490363134"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""30b1688a-debb-45c9-b056-0cccc8158e8f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""08d8959a-536b-4951-a30f-a3114a33f7ef"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d7e1d6e9-338a-4c3f-9297-f0c1a4928121"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""52fad98f-d04e-4b04-9811-3f7728892f88"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""153eec8d-3a9e-4846-9f03-21f7dbb8ed34"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64095c93-caa9-41b7-bc81-aced4f165453"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4267135-6505-4232-8f67-88e1c4a0dbc5"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""debugChangePlatform"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d761bc7c-a3f1-4269-a2cb-30ea3d885829"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PauseEscape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efc66f63-8ebb-4445-a9e2-918d18f52f5a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""PauseEscape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""53be03e7-2949-4a69-b5b7-565c7a2d9789"",
            ""actions"": [
                {
                    ""name"": ""GoBack"",
                    ""type"": ""Button"",
                    ""id"": ""a8344af4-49ea-47de-80d5-a17078c2eae8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GetClick"",
                    ""type"": ""Button"",
                    ""id"": ""d6dac4f1-a730-4db3-a414-777453f4f806"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""41358562-0e6b-481f-bff2-2515faff5b36"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb838554-762f-4955-9b3c-b19dbf35b93c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GoBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cab052b3-1ee0-443f-a7c0-87d417d109ba"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""303005af-5910-495c-87b6-bb7bc7a0a535"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""GetClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a75abc7-0e53-4f14-a492-4cb6d0f814d0"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""GetClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c80bef10-df85-49bb-9dbd-f2ce5f34c43e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""GetClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard + Mouse"",
            ""bindingGroup"": ""Keyboard + Mouse"",
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
        // Controll
        m_Controll = asset.FindActionMap("Controll", throwIfNotFound: true);
        m_Controll_Move = m_Controll.FindAction("Move", throwIfNotFound: true);
        m_Controll_MoveVertical = m_Controll.FindAction("MoveVertical", throwIfNotFound: true);
        m_Controll_Jump = m_Controll.FindAction("Jump", throwIfNotFound: true);
        m_Controll_ActionE = m_Controll.FindAction("ActionE", throwIfNotFound: true);
        m_Controll_ActionS = m_Controll.FindAction("ActionS", throwIfNotFound: true);
        m_Controll_Run = m_Controll.FindAction("Run", throwIfNotFound: true);
        m_Controll_debugChangePlatform = m_Controll.FindAction("debugChangePlatform", throwIfNotFound: true);
        m_Controll_PauseEscape = m_Controll.FindAction("PauseEscape", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_GoBack = m_Menu.FindAction("GoBack", throwIfNotFound: true);
        m_Menu_GetClick = m_Menu.FindAction("GetClick", throwIfNotFound: true);
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

    // Controll
    private readonly InputActionMap m_Controll;
    private IControllActions m_ControllActionsCallbackInterface;
    private readonly InputAction m_Controll_Move;
    private readonly InputAction m_Controll_MoveVertical;
    private readonly InputAction m_Controll_Jump;
    private readonly InputAction m_Controll_ActionE;
    private readonly InputAction m_Controll_ActionS;
    private readonly InputAction m_Controll_Run;
    private readonly InputAction m_Controll_debugChangePlatform;
    private readonly InputAction m_Controll_PauseEscape;
    public struct ControllActions
    {
        private @InputControll m_Wrapper;
        public ControllActions(@InputControll wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Controll_Move;
        public InputAction @MoveVertical => m_Wrapper.m_Controll_MoveVertical;
        public InputAction @Jump => m_Wrapper.m_Controll_Jump;
        public InputAction @ActionE => m_Wrapper.m_Controll_ActionE;
        public InputAction @ActionS => m_Wrapper.m_Controll_ActionS;
        public InputAction @Run => m_Wrapper.m_Controll_Run;
        public InputAction @debugChangePlatform => m_Wrapper.m_Controll_debugChangePlatform;
        public InputAction @PauseEscape => m_Wrapper.m_Controll_PauseEscape;
        public InputActionMap Get() { return m_Wrapper.m_Controll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllActions set) { return set.Get(); }
        public void SetCallbacks(IControllActions instance)
        {
            if (m_Wrapper.m_ControllActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnMove;
                @MoveVertical.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnMoveVertical;
                @MoveVertical.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnMoveVertical;
                @MoveVertical.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnMoveVertical;
                @Jump.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnJump;
                @ActionE.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnActionE;
                @ActionE.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnActionE;
                @ActionE.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnActionE;
                @ActionS.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnActionS;
                @ActionS.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnActionS;
                @ActionS.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnActionS;
                @Run.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnRun;
                @debugChangePlatform.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnDebugChangePlatform;
                @debugChangePlatform.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnDebugChangePlatform;
                @debugChangePlatform.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnDebugChangePlatform;
                @PauseEscape.started -= m_Wrapper.m_ControllActionsCallbackInterface.OnPauseEscape;
                @PauseEscape.performed -= m_Wrapper.m_ControllActionsCallbackInterface.OnPauseEscape;
                @PauseEscape.canceled -= m_Wrapper.m_ControllActionsCallbackInterface.OnPauseEscape;
            }
            m_Wrapper.m_ControllActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveVertical.started += instance.OnMoveVertical;
                @MoveVertical.performed += instance.OnMoveVertical;
                @MoveVertical.canceled += instance.OnMoveVertical;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @ActionE.started += instance.OnActionE;
                @ActionE.performed += instance.OnActionE;
                @ActionE.canceled += instance.OnActionE;
                @ActionS.started += instance.OnActionS;
                @ActionS.performed += instance.OnActionS;
                @ActionS.canceled += instance.OnActionS;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @debugChangePlatform.started += instance.OnDebugChangePlatform;
                @debugChangePlatform.performed += instance.OnDebugChangePlatform;
                @debugChangePlatform.canceled += instance.OnDebugChangePlatform;
                @PauseEscape.started += instance.OnPauseEscape;
                @PauseEscape.performed += instance.OnPauseEscape;
                @PauseEscape.canceled += instance.OnPauseEscape;
            }
        }
    }
    public ControllActions @Controll => new ControllActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_GoBack;
    private readonly InputAction m_Menu_GetClick;
    public struct MenuActions
    {
        private @InputControll m_Wrapper;
        public MenuActions(@InputControll wrapper) { m_Wrapper = wrapper; }
        public InputAction @GoBack => m_Wrapper.m_Menu_GoBack;
        public InputAction @GetClick => m_Wrapper.m_Menu_GetClick;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @GoBack.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnGoBack;
                @GoBack.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnGoBack;
                @GoBack.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnGoBack;
                @GetClick.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnGetClick;
                @GetClick.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnGetClick;
                @GetClick.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnGetClick;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GoBack.started += instance.OnGoBack;
                @GoBack.performed += instance.OnGoBack;
                @GoBack.canceled += instance.OnGoBack;
                @GetClick.started += instance.OnGetClick;
                @GetClick.performed += instance.OnGetClick;
                @GetClick.canceled += instance.OnGetClick;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard + Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
    public interface IControllActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveVertical(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnActionE(InputAction.CallbackContext context);
        void OnActionS(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDebugChangePlatform(InputAction.CallbackContext context);
        void OnPauseEscape(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnGoBack(InputAction.CallbackContext context);
        void OnGetClick(InputAction.CallbackContext context);
    }
}
