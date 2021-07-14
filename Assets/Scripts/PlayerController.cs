// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace PlayerController
{
    public class @PlayerController : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerController()
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
                    ""name"": ""Turn"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8439aaa6-e816-434e-93c0-5ee44b455b74"",
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
                    ""name"": ""OpenDoor"",
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
                    ""id"": ""03bfa76f-7bb8-4241-b89e-642740843f55"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efdf9d86-214e-4ae5-96fd-8c6c2b1fdfd4"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
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
                    ""id"": ""6486ca0d-b511-4d54-93f6-f274e5a47ffd"",
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
                    ""id"": ""8f3d2afc-9573-46d8-9a1b-d482c17e1fe9"",
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
                    ""id"": ""557f5a17-7b6d-4861-9f49-baeade9eede1"",
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
                    ""action"": ""OpenDoor"",
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
                    ""action"": ""OpenDoor"",
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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
            m_Player_Turn = m_Player.FindAction("Turn", throwIfNotFound: true);
            m_Player_ActivateRightItem = m_Player.FindAction("ActivateRightItem", throwIfNotFound: true);
            m_Player_ActivateLeftItem = m_Player.FindAction("ActivateLeftItem", throwIfNotFound: true);
            m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
            m_Player_OpenDoor = m_Player.FindAction("OpenDoor", throwIfNotFound: true);
            m_Player_FastGrabWaTa = m_Player.FindAction("FastGrabWaTa", throwIfNotFound: true);
            m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
            m_Player_TakeItem = m_Player.FindAction("TakeItem", throwIfNotFound: true);
            m_Player_ItemList = m_Player.FindAction("ItemList", throwIfNotFound: true);
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
        private readonly InputAction m_Player_Turn;
        private readonly InputAction m_Player_ActivateRightItem;
        private readonly InputAction m_Player_ActivateLeftItem;
        private readonly InputAction m_Player_Run;
        private readonly InputAction m_Player_OpenDoor;
        private readonly InputAction m_Player_FastGrabWaTa;
        private readonly InputAction m_Player_Action;
        private readonly InputAction m_Player_TakeItem;
        private readonly InputAction m_Player_ItemList;
        public struct PlayerActions
        {
            private @PlayerController m_Wrapper;
            public PlayerActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
            public InputAction @Walk => m_Wrapper.m_Player_Walk;
            public InputAction @Turn => m_Wrapper.m_Player_Turn;
            public InputAction @ActivateRightItem => m_Wrapper.m_Player_ActivateRightItem;
            public InputAction @ActivateLeftItem => m_Wrapper.m_Player_ActivateLeftItem;
            public InputAction @Run => m_Wrapper.m_Player_Run;
            public InputAction @OpenDoor => m_Wrapper.m_Player_OpenDoor;
            public InputAction @FastGrabWaTa => m_Wrapper.m_Player_FastGrabWaTa;
            public InputAction @Action => m_Wrapper.m_Player_Action;
            public InputAction @TakeItem => m_Wrapper.m_Player_TakeItem;
            public InputAction @ItemList => m_Wrapper.m_Player_ItemList;
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
                    @Turn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                    @Turn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                    @Turn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                    @ActivateRightItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateRightItem;
                    @ActivateRightItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateRightItem;
                    @ActivateRightItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateRightItem;
                    @ActivateLeftItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateLeftItem;
                    @ActivateLeftItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateLeftItem;
                    @ActivateLeftItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnActivateLeftItem;
                    @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                    @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                    @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                    @OpenDoor.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenDoor;
                    @OpenDoor.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenDoor;
                    @OpenDoor.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenDoor;
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
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Walk.started += instance.OnWalk;
                    @Walk.performed += instance.OnWalk;
                    @Walk.canceled += instance.OnWalk;
                    @Turn.started += instance.OnTurn;
                    @Turn.performed += instance.OnTurn;
                    @Turn.canceled += instance.OnTurn;
                    @ActivateRightItem.started += instance.OnActivateRightItem;
                    @ActivateRightItem.performed += instance.OnActivateRightItem;
                    @ActivateRightItem.canceled += instance.OnActivateRightItem;
                    @ActivateLeftItem.started += instance.OnActivateLeftItem;
                    @ActivateLeftItem.performed += instance.OnActivateLeftItem;
                    @ActivateLeftItem.canceled += instance.OnActivateLeftItem;
                    @Run.started += instance.OnRun;
                    @Run.performed += instance.OnRun;
                    @Run.canceled += instance.OnRun;
                    @OpenDoor.started += instance.OnOpenDoor;
                    @OpenDoor.performed += instance.OnOpenDoor;
                    @OpenDoor.canceled += instance.OnOpenDoor;
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
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnWalk(InputAction.CallbackContext context);
            void OnTurn(InputAction.CallbackContext context);
            void OnActivateRightItem(InputAction.CallbackContext context);
            void OnActivateLeftItem(InputAction.CallbackContext context);
            void OnRun(InputAction.CallbackContext context);
            void OnOpenDoor(InputAction.CallbackContext context);
            void OnFastGrabWaTa(InputAction.CallbackContext context);
            void OnAction(InputAction.CallbackContext context);
            void OnTakeItem(InputAction.CallbackContext context);
            void OnItemList(InputAction.CallbackContext context);
        }
    }
}
