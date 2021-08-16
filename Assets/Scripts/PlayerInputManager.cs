// Digx7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputManager : MonoBehaviour {
    /* Description --
    *  This script will handel the player inputs using the new input manager package
    *  This should be what every thing else in the scene refrences when getting the player input
    */

    [SerializeField] private Player_Controls Player_Controls;                  // This references the input action map
    [SerializeField] private bool isOn = true;

    //[SerializeField] private Vector2 moveDirection;

    [SerializeField] private Vector2Event comboInput;
    [SerializeField] private Vector2Event moveInput;



    // --- Updates -------------------------------------

    public void Awake() {
        Player_Controls = new Player_Controls();             // This is needed to set up the input action map

        BindInputs();
    }

    // --- Get/Set -------------------------------------

    /*private void setMoveDirection(Vector2 input){
      moveDirection = input;
      if(isOn) {
        moveInput.Invoke(moveDirection);
        if(moveDirection.x > 0.1 || moveDirection.x < -0.1 || moveDirection.y > 0.1 || moveDirection.y < -0.1){
          playFootsteps.Invoke();
          Debug.Log("Playing Footsteps sfx");
        }
        else{
          stopFootsteps.Invoke();
          Debug.Log("Stopping Footsteps sfx");
        }
      }
      else {
        moveInput.Invoke(new Vector2(0,0));
      }
    }

    public Vector2 getMoveDirection(){
      return moveDirection;
    }*/

    public bool getIsOn(){
      return isOn;
    }

    public void toggleIsOn(){
      isOn = !isOn;

      //if(!isOn) setMoveDirection(new Vector2(0,0));
    }

    // --- Events -------------------------------------

    private void ComboInputEvent(Vector2 input)
    {
        if(isOn)comboInput.Invoke(input);
    }

    private void MovementInputEvent(Vector2 input)
    {
        if(isOn)moveInput.Invoke(input);
    }

    // --- BindingInputs ----------------------------------

    // This script will bind the inputs on the Input action map to the needed script
    public void BindInputs() {
        Player_Controls.Combo.Arrows.performed += ctx => ComboInputEvent(ctx.ReadValue<Vector2>());
        Player_Controls.Character.Move.performed += ctx => MovementInputEvent(ctx.ReadValue<Vector2>());
    }

    // --- Enable/Disable --------------------------------

    // This will enable the Input Action Map
    private void OnEnable() {
        Player_Controls.Enable();
    }

    // This will enable the Input Action Map
    private void OnDisable() {
        Player_Controls.Disable();
    }
}
