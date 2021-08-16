// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player_Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Controls"",
    ""maps"": [
        {
            ""name"": ""Combo"",
            ""id"": ""0da73fc4-fb3c-4b60-bed1-8275d369a034"",
            ""actions"": [
                {
                    ""name"": ""Arrows"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7a2c5d49-697c-4c75-94e8-313b5a328022"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""40dc87f8-0850-4558-898f-bdc9f02bca81"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2b6e39ee-e5aa-4a06-bb45-7b1090f9e2bd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5e3b611-a4e5-4720-b2d0-ca0a9019d1be"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""031f6185-9c94-4fe9-b092-ddb6019634fb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""07f64d7d-d3c9-40fc-9150-6a428fe2e1d3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrows"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Character"",
            ""id"": ""57ee60f9-3bce-4817-9c78-c5547ec8b92b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a9f9cb39-5417-4987-92ff-052c020a4afb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""37074bce-d650-4469-80c6-6df7e6f3ad96"",
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
                    ""id"": ""b54d9e25-7583-49a3-86ee-58e40746f0be"",
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
                    ""id"": ""1a25ae88-9b41-4e12-b346-c3f9e0444ed3"",
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
                    ""id"": ""0a61593e-5405-4051-9c85-40737dce4e66"",
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
                    ""id"": ""498e7bc3-8b0b-455d-9e8e-ce4765dae1ef"",
                    ""path"": ""<Keyboard>/d"",
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
        // Combo
        m_Combo = asset.FindActionMap("Combo", throwIfNotFound: true);
        m_Combo_Arrows = m_Combo.FindAction("Arrows", throwIfNotFound: true);
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Move = m_Character.FindAction("Move", throwIfNotFound: true);
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

    // Combo
    private readonly InputActionMap m_Combo;
    private IComboActions m_ComboActionsCallbackInterface;
    private readonly InputAction m_Combo_Arrows;
    public struct ComboActions
    {
        private @Player_Controls m_Wrapper;
        public ComboActions(@Player_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Arrows => m_Wrapper.m_Combo_Arrows;
        public InputActionMap Get() { return m_Wrapper.m_Combo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ComboActions set) { return set.Get(); }
        public void SetCallbacks(IComboActions instance)
        {
            if (m_Wrapper.m_ComboActionsCallbackInterface != null)
            {
                @Arrows.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnArrows;
                @Arrows.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnArrows;
                @Arrows.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnArrows;
            }
            m_Wrapper.m_ComboActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Arrows.started += instance.OnArrows;
                @Arrows.performed += instance.OnArrows;
                @Arrows.canceled += instance.OnArrows;
            }
        }
    }
    public ComboActions @Combo => new ComboActions(this);

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Move;
    public struct CharacterActions
    {
        private @Player_Controls m_Wrapper;
        public CharacterActions(@Player_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Character_Move;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface IComboActions
    {
        void OnArrows(InputAction.CallbackContext context);
    }
    public interface ICharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
