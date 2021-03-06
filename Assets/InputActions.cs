// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerAction"",
            ""id"": ""f94c85c2-fe0d-4b41-a578-79453e07e2c0"",
            ""actions"": [
                {
                    ""name"": ""leftMosuseClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""db543686-abf1-48cf-91d7-8ba6f2e93369"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMouseClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""57b1c9c3-fef6-4df0-8b2d-b6156a31b37a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f49e780e-8b8f-4f30-8ed9-d78743022383"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15dbbb0d-c8e1-47d6-b729-98d39677ee4c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftMosuseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d7839b4-aaf1-4326-9c9c-c6694b72bec9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b39d8a97-f4b1-4c6e-8e53-133c58ea761a"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""d6f9ff63-13c1-427b-b887-fba0ce6afd0b"",
            ""actions"": [
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""Button"",
                    ""id"": ""fbda835d-e5b6-4fbb-81d1-9d8a4f55e4cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow"",
                    ""id"": ""05bf0269-c353-486c-91be-93ad2c3692ea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2db9d810-e7f9-4978-9b67-1dd063b257e7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f0af17b9-4d00-4abb-b0ad-d462564dff5e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0e4ea97f-8b26-48cd-a9a3-386c53b60da0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1cc03cc3-0e63-4221-bea8-3385da1317f1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerAction
        m_PlayerAction = asset.FindActionMap("PlayerAction", throwIfNotFound: true);
        m_PlayerAction_leftMosuseClick = m_PlayerAction.FindAction("leftMosuseClick", throwIfNotFound: true);
        m_PlayerAction_RightMouseClick = m_PlayerAction.FindAction("RightMouseClick", throwIfNotFound: true);
        m_PlayerAction_mousePosition = m_PlayerAction.FindAction("mousePosition", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_MoveCamera = m_Camera.FindAction("MoveCamera", throwIfNotFound: true);
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

    // PlayerAction
    private readonly InputActionMap m_PlayerAction;
    private IPlayerActionActions m_PlayerActionActionsCallbackInterface;
    private readonly InputAction m_PlayerAction_leftMosuseClick;
    private readonly InputAction m_PlayerAction_RightMouseClick;
    private readonly InputAction m_PlayerAction_mousePosition;
    public struct PlayerActionActions
    {
        private @InputActions m_Wrapper;
        public PlayerActionActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @leftMosuseClick => m_Wrapper.m_PlayerAction_leftMosuseClick;
        public InputAction @RightMouseClick => m_Wrapper.m_PlayerAction_RightMouseClick;
        public InputAction @mousePosition => m_Wrapper.m_PlayerAction_mousePosition;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionActions instance)
        {
            if (m_Wrapper.m_PlayerActionActionsCallbackInterface != null)
            {
                @leftMosuseClick.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftMosuseClick;
                @leftMosuseClick.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftMosuseClick;
                @leftMosuseClick.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftMosuseClick;
                @RightMouseClick.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightMouseClick;
                @RightMouseClick.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightMouseClick;
                @RightMouseClick.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightMouseClick;
                @mousePosition.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMousePosition;
                @mousePosition.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMousePosition;
                @mousePosition.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_PlayerActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @leftMosuseClick.started += instance.OnLeftMosuseClick;
                @leftMosuseClick.performed += instance.OnLeftMosuseClick;
                @leftMosuseClick.canceled += instance.OnLeftMosuseClick;
                @RightMouseClick.started += instance.OnRightMouseClick;
                @RightMouseClick.performed += instance.OnRightMouseClick;
                @RightMouseClick.canceled += instance.OnRightMouseClick;
                @mousePosition.started += instance.OnMousePosition;
                @mousePosition.performed += instance.OnMousePosition;
                @mousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public PlayerActionActions @PlayerAction => new PlayerActionActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_MoveCamera;
    public struct CameraActions
    {
        private @InputActions m_Wrapper;
        public CameraActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCamera => m_Wrapper.m_Camera_MoveCamera;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @MoveCamera.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMoveCamera;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveCamera.started += instance.OnMoveCamera;
                @MoveCamera.performed += instance.OnMoveCamera;
                @MoveCamera.canceled += instance.OnMoveCamera;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IPlayerActionActions
    {
        void OnLeftMosuseClick(InputAction.CallbackContext context);
        void OnRightMouseClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnMoveCamera(InputAction.CallbackContext context);
    }
}
