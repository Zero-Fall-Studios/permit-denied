// GENERATED AUTOMATICALLY FROM 'Assets/RFGInput/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace RFG
{
  public class @PlayerInputActions : IInputActionCollection, IDisposable
  {
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
      asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""de3936c2-0e56-4719-8779-34a71c490a7f"",
            ""actions"": [
                {
                    ""name"": ""PrimaryAttack"",
                    ""type"": ""Button"",
                    ""id"": ""1ddd5fe3-197d-47db-833e-73e98d7a2858"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryAttack"",
                    ""type"": ""Button"",
                    ""id"": ""ab86883e-3cca-44a1-936c-8c3b6a9bf0ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b4300cfe-45bb-462c-bb1d-f1e6f3eda736"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""681f4496-9d99-4c21-8171-15546399fc5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6459d2b5-338a-409f-9aea-ed4187e38f3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""a842d16c-43e2-4db9-b6f4-4c34e7d3f4cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""b26a45a7-a87f-40ca-baa9-3d491df7ea0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""045528e0-3dc9-4484-92ed-1dffcb23ab22"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PrimaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e92ae915-54d9-4a90-919a-87d72bf96d97"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PrimaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""95b135db-a12d-4848-b3b2-c22d4886d85f"",
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
                    ""id"": ""06b0e87c-473d-4654-a7d8-89e563af0cc6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fa0884e6-905d-489c-8e5b-a7b0b54aa6fd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e64140f7-1c8b-4f9a-b514-91e533e7de8d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1910e9c5-beff-49bb-b085-2d992e5256b5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Stick"",
                    ""id"": ""d2e8f86d-d5d0-4b6a-8bf6-1e1d0c14ea80"",
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
                    ""id"": ""38a09444-a91f-44ee-96d6-ad3a9ec42d20"",
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
                    ""id"": ""e4cbf467-1459-471b-b003-61d5313d68f4"",
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
                    ""id"": ""761109c3-7f7a-4b00-a634-ac367a369c65"",
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
                    ""id"": ""7738df2c-274b-4523-a6a3-81683f47c7dc"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3a98f55-43be-483d-9381-a8c22dad14fe"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""763e41f7-b98d-4d26-a65c-4e76736410b7"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b96df50-0d9f-407b-b1ba-7c17a0202d76"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SecondaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3807bd5-d3ad-4ef7-9d56-3edab2a242ae"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SecondaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c96a6e2c-9bcd-4756-abae-cd9d1083a290"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""052e1a56-a05c-4de0-8f45-0cf0c64819f0"",
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
                    ""id"": ""7105f90b-605c-4789-8c51-2e1959c02588"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14c6d7ba-ad72-46f0-a702-9a6aa2f36ba0"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0b99ef6-6144-4a06-8a6e-cefc6f83398a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db1bd919-9600-416e-9fe6-f2161233b614"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
      // PlayerControls
      m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
      m_PlayerControls_PrimaryAttack = m_PlayerControls.FindAction("PrimaryAttack", throwIfNotFound: true);
      m_PlayerControls_SecondaryAttack = m_PlayerControls.FindAction("SecondaryAttack", throwIfNotFound: true);
      m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
      m_PlayerControls_Pause = m_PlayerControls.FindAction("Pause", throwIfNotFound: true);
      m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
      m_PlayerControls_Dash = m_PlayerControls.FindAction("Dash", throwIfNotFound: true);
      m_PlayerControls_Use = m_PlayerControls.FindAction("Use", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_PrimaryAttack;
    private readonly InputAction m_PlayerControls_SecondaryAttack;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Pause;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Dash;
    private readonly InputAction m_PlayerControls_Use;
    public struct PlayerControlsActions
    {
      private @PlayerInputActions m_Wrapper;
      public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
      public InputAction @PrimaryAttack => m_Wrapper.m_PlayerControls_PrimaryAttack;
      public InputAction @SecondaryAttack => m_Wrapper.m_PlayerControls_SecondaryAttack;
      public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
      public InputAction @Pause => m_Wrapper.m_PlayerControls_Pause;
      public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
      public InputAction @Dash => m_Wrapper.m_PlayerControls_Dash;
      public InputAction @Use => m_Wrapper.m_PlayerControls_Use;
      public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
      public void Enable() { Get().Enable(); }
      public void Disable() { Get().Disable(); }
      public bool enabled => Get().enabled;
      public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
      public void SetCallbacks(IPlayerControlsActions instance)
      {
        if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
        {
          @PrimaryAttack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryAttack;
          @PrimaryAttack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryAttack;
          @PrimaryAttack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryAttack;
          @SecondaryAttack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSecondaryAttack;
          @SecondaryAttack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSecondaryAttack;
          @SecondaryAttack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSecondaryAttack;
          @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
          @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
          @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
          @Pause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
          @Pause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
          @Pause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
          @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
          @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
          @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
          @Dash.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
          @Dash.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
          @Dash.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
          @Use.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse;
          @Use.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse;
          @Use.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse;
        }
        m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
        if (instance != null)
        {
          @PrimaryAttack.started += instance.OnPrimaryAttack;
          @PrimaryAttack.performed += instance.OnPrimaryAttack;
          @PrimaryAttack.canceled += instance.OnPrimaryAttack;
          @SecondaryAttack.started += instance.OnSecondaryAttack;
          @SecondaryAttack.performed += instance.OnSecondaryAttack;
          @SecondaryAttack.canceled += instance.OnSecondaryAttack;
          @Movement.started += instance.OnMovement;
          @Movement.performed += instance.OnMovement;
          @Movement.canceled += instance.OnMovement;
          @Pause.started += instance.OnPause;
          @Pause.performed += instance.OnPause;
          @Pause.canceled += instance.OnPause;
          @Jump.started += instance.OnJump;
          @Jump.performed += instance.OnJump;
          @Jump.canceled += instance.OnJump;
          @Dash.started += instance.OnDash;
          @Dash.performed += instance.OnDash;
          @Dash.canceled += instance.OnDash;
          @Use.started += instance.OnUse;
          @Use.performed += instance.OnUse;
          @Use.canceled += instance.OnUse;
        }
      }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
      get
      {
        if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
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
    public interface IPlayerControlsActions
    {
      void OnPrimaryAttack(InputAction.CallbackContext context);
      void OnSecondaryAttack(InputAction.CallbackContext context);
      void OnMovement(InputAction.CallbackContext context);
      void OnPause(InputAction.CallbackContext context);
      void OnJump(InputAction.CallbackContext context);
      void OnDash(InputAction.CallbackContext context);
      void OnUse(InputAction.CallbackContext context);
    }
  }
}
