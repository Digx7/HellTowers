using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectInDirectionOfMotion : MonoBehaviour
{
    [SerializeField]
    private Rigidbody objectInMotion;
    private Vector3 directionOfMotion;
    [SerializeField]
    private Transform objectToRotate;
    [SerializeField]
    private float speed;
    private float maxMagnitudeD = 100000000;

    [SerializeField]
    private bool snapsBackUnderNoMotion = false;

    private void FixedUpdate(){
        setDirectionOfMotion(objectInMotion.velocity);
        if(canRotate()) applyRotation();
    }

    private void setDirectionOfMotion(Vector3 input){
      directionOfMotion = input;
    }

    private void applyRotation(){
      Vector3 newDirection = Vector3.RotateTowards(objectToRotate.forward, directionOfMotion, speed, maxMagnitudeD);
      Debug.DrawRay(objectToRotate.position, newDirection, Color.red);
      objectToRotate.rotation = Quaternion.LookRotation(newDirection);
    }

    private bool canRotate(){
      if(!snapsBackUnderNoMotion){
        if(directionOfMotion.magnitude >= 0.1 || directionOfMotion.magnitude <= -0.1) return true;
        else return false;
      }
      else return true;
    }

    public void setObjectToRotate(Transform input){
      objectToRotate = input;
    }
}
