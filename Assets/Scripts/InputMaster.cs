// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e2019936-1c15-4fab-a6c7-0d5055269984"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d101166-79dd-46e3-a431-257fdd350ed4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2ff0943e-2860-4f02-8303-0a0f752ab241"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateRightItem"",
                    ""type"": ""Button"",
                    ""id"": ""fc70ac72-fcb3-4d6f-923a-fde2e81974aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateLeftItem"",
                    ""type"": ""Button"",
                    ""id"": ""e92adb7f-f2c4-400f-ba6b-e6adb2bd2935"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""c97dc209-baab-4311-83fa-f58ab3b804f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""be6b8ca2-993d-4b3b-b571-558c70f93df3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastGrabWaTa"",
                    ""type"": ""Button"",
                    ""id"": ""b3ea5822-e41d-4e0b-8b21-4c3342b5637d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""f7610d2a-a145-4054-b653-22757703fd54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakeItem"",
                    ""type"": ""Button"",
                    ""id"": ""b637a348-f820-4cc6-ac89-fd4afa8f8f03"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ItemList"",
                    ""type"": ""Button"",
                    ""id"": ""68af37a6-6bff-4adc-a35f-85084556c6b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""a13f38b6-b58c-4ddb-9885-e98e2db91b73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropItemLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e0fe5ce4-f2ad-4520-940f-68de3de3f174"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropItemRight"",
                    ""type"": ""Button"",
                    ""id"": ""449a88f5-2a08-499c-9813-a5d8ffbcaa90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchItemLeft"",
                    ""type"": ""Button"",
                    ""id"": ""0f1f1277-45b1-4db3-856c-bedba04ef589"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchItemRight"",
                    ""type"": ""Button"",
                    ""id"": ""20bd791a-a4dd-4c32-aa40-7857c752b2d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""53faa89f-a118-4ac2-b17f-20dd50718a15"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e9191d8-e9b2-412a-9a55-65214cab5ff3"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50c3c3a5-94a1-4195-a700-c87346685e9b"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateRightItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95020832-2fe7-4a83-b274-b3740e2055b8"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateRightItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""557f5a17-7b6d-4861-9f49-baeade9eede1"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateLeftItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b1dae5b-6d2b-4b0a-9c2a-e9ddedc65172"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateLeftItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6deb32e-7b04-4654-bed5-4af0f31c1160"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8ed9068-0c15-4d9b-b5f4-691235428b30"",
                    ""path"": ""<XboxOneGampadiOS>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aad2fb73-1147-403b-afc0-137890538839"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc3ad528-cb6f-4840-afea-1dc4c6626c43"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f03dbf33-5f56-486c-9159-015e22c9a7bf"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastGrabWaTa"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd2f53da-b8dc-4706-a645-fb85b4a5552c"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastGrabWaTa"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5c89fe4-78cb-482b-8bef-38de7e24b6d7"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f36d621-9055-4874-851e-5c59c08c63bd"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9f78288-2a9a-41db-aee9-a6c46288daf2"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakeItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a71d42a1-f985-402c-a7c6-e781f2843700"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakeItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd65389d-4ed1-4717-83ba-c3c102744c19"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ItemList"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60f9aa06-bd14-4688-829b-ce68277dc8d1"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ItemList"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11350884-fa4f-4370-9dd9-c2c798e8b9ab"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9886f969-0783-4167-92cf-6d0d7f3604c9"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfe6d0a1-06f3-41c4-83c6-47f3051e89b7"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItemLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3092fc0b-defe-434d-9555-6c48faf658b6"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItemLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f21e198-37b8-400c-b7d7-0e4e004eb6e0"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItemRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2781d2b6-7d59-438e-bb98-37e53bfb6fde"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItemRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f847247a-7484-44af-84cb-88d5b1f266b6"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3fa82a0-37a5-42ca-a7e8-2ebad0878294"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc53c765-dad0-44cc-9bb8-8a8fb5637b45"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5be4a116-d27d-4465-93bf-59e7699305a1"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchItemRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f43108f5-6a00-491f-a22b-313d8429c27b"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc9cdaee-90b0-4ce0-91b9-3b9ffc36a1b8"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""6d288bdb-d09f-46c2-8921-e34bb3787cd0"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""5e1a23c7-5094-4d1c-bac6-3067d3c95575"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85f9a472-c8e6-4682-91ff-d8868feeb94d"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_ActivateRightItem = m_Player.FindAction("ActivateRightItem", throwIfNotFound: true);
        m_Player_ActivateLeftItem = m_Player.FindAction("ActivateLeftItem", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_FastGrabWaTa = m_Player.FindAction("FastGrabWaTa", throwIfNotFound: true);
        m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
        m_Player_TakeItem = m_Player.FindAction("TakeItem", throwIfNotFound: true);
        m_Player_ItemList = m_Player.FindAction("ItemList", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
        m_Player_DropItemLeft = m_Player.FindAction("DropItemLeft", throwIfNotFound: true);
        m_Player_DropItemRight = m_Player.FindAction("DropItemRight", throwIfNotFound: true);
        m_Player_SwitchItemLeft = m_Player.FindAction("SwitchItemLeft", throwIfNotFound: true);
        m_Player_SwitchItemRight = m_Player.FindAction("SwitchItemRight", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_ActivateRightItem;
    private readonly InputAction m_Player_ActivateLeftItem;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_FastGrabWaTa;
    private readonly InputAction m_Player_Action;
    private readonly InputAction m_Player_TakeItem;
    private readonly InputAction m_Player_ItemList;
    private readonly InputAction m_Player_Menu;
    private readonly InputAction m_Player_DropItemLeft;
    private readonly InputAction m_Player_DropItemRight;
    private readonly InputAction m_Player_SwitchItemLeft;
    private readonly InputAction m_Player_SwitchItemRight;
    public struct PlayerActions
    {
        private @PlayerControlls m_Wrapper;
        public PlayerActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @ActivateRightItem => m_Wrapper.m_Player_ActivateRightItem;
        public InputAction @ActivateLeftItem => m_Wrapper.m_Player_ActivateLeftItem;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @FastGrabWaTa => m_Wrapper.m_Player_FastGrabWaTa;
        public InputAction @Action => m_Wrapper.m_Player_Action;
        public InputAction @TakeItem => m_Wrapper.m_Player_TakeItem;
        public InputAction @ItemList => m_Wrapper.m_Player_ItemList;
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputAction @DropItemLeft => m_Wrapper.m_Player_DropItemLeft;
        public InputAction @DropItemRight => m_Wrapper.m_Player_DropItemRight;
        public InputAction @SwitchItemLeft => m_Wrapper.m_Player_SwitchItemLeft;
        public InputAction @SwitchItemRight => m_Wrapper.m_Player_SwitchItemRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @ActivateRightItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateRightItem;
                @ActivateRightItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateRightItem;
                @ActivateRightItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateRightItem;
                @ActivateLeftItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateLeftItem;
                @ActivateLeftItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateLeftItem;
                @ActivateLeftItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateLeftItem;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @FastGrabWaTa.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFastGrabWaTa;
                @FastGrabWaTa.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFastGrabWaTa;
                @FastGrabWaTa.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFastGrabWaTa;
                @Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @TakeItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeItem;
                @TakeItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeItem;
                @TakeItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeItem;
                @ItemList.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemList;
                @ItemList.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemList;
                @ItemList.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnItemList;
                @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @DropItemLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItemLeft;
                @DropItemLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItemLeft;
                @DropItemLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItemLeft;
                @DropItemRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItemRight;
                @DropItemRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItemRight;
                @DropItemRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropItemRight;
                @SwitchItemLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItemLeft;
                @SwitchItemLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItemLeft;
                @SwitchItemLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItemLeft;
                @SwitchItemRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItemRight;
                @SwitchItemRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItemRight;
                @SwitchItemRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchItemRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @ActivateRightItem.started += instance.OnActivateRightItem;
                @ActivateRightItem.performed += instance.OnActivateRightItem;
                @ActivateRightItem.canceled += instance.OnActivateRightItem;
                @ActivateLeftItem.started += instance.OnActivateLeftItem;
                @ActivateLeftItem.performed += instance.OnActivateLeftItem;
                @ActivateLeftItem.canceled += instance.OnActivateLeftItem;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @FastGrabWaTa.started += instance.OnFastGrabWaTa;
                @FastGrabWaTa.performed += instance.OnFastGrabWaTa;
                @FastGrabWaTa.canceled += instance.OnFastGrabWaTa;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @TakeItem.started += instance.OnTakeItem;
                @TakeItem.performed += instance.OnTakeItem;
                @TakeItem.canceled += instance.OnTakeItem;
                @ItemList.started += instance.OnItemList;
                @ItemList.performed += instance.OnItemList;
                @ItemList.canceled += instance.OnItemList;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @DropItemLeft.started += instance.OnDropItemLeft;
                @DropItemLeft.performed += instance.OnDropItemLeft;
                @DropItemLeft.canceled += instance.OnDropItemLeft;
                @DropItemRight.started += instance.OnDropItemRight;
                @DropItemRight.performed += instance.OnDropItemRight;
                @DropItemRight.canceled += instance.OnDropItemRight;
                @SwitchItemLeft.started += instance.OnSwitchItemLeft;
                @SwitchItemLeft.performed += instance.OnSwitchItemLeft;
                @SwitchItemLeft.canceled += instance.OnSwitchItemLeft;
                @SwitchItemRight.started += instance.OnSwitchItemRight;
                @SwitchItemRight.performed += instance.OnSwitchItemRight;
                @SwitchItemRight.canceled += instance.OnSwitchItemRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @PlayerControlls m_Wrapper;
        public MenuActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnActivateRightItem(InputAction.CallbackContext context);
        void OnActivateLeftItem(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnFastGrabWaTa(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnTakeItem(InputAction.CallbackContext context);
        void OnItemList(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnDropItemLeft(InputAction.CallbackContext context);
        void OnDropItemRight(InputAction.CallbackContext context);
        void OnSwitchItemLeft(InputAction.CallbackContext context);
        void OnSwitchItemRight(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
