using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ComboInteraction : MonoBehaviour
{
    [SerializeField]
    private List<ArrowDirection> arrowDirections;

    [SerializeField]
    private bool isOn = false;

    [SerializeField]
    private int currentIndex;

    public UnityEvent comboSuccess;
    public UnityEvent comboFail;

    public void InputReceiver(Vector2 input){
      if(input.y > 0.1) UpInput();
      else if(input.y < -0.1) DownInput();

      if(input.x > 0.1) LeftInput();
      else if(input.x < -0.1) RightInput();
    }

    public void UpInput(){

    }

    public void DownInput(){

    }

    public void LeftInput(){

    }

    public void RightInput(){

    }


}
