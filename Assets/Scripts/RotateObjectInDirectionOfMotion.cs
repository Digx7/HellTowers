using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectInDirectionOfMotion : MonoBehaviour
{
    [SerializeField]
    private Rigidbody objectInMotion;
    private Vector3 directionOfMotion;
    [SerializeField]
    private GameObject objectToRotate;

    private void FixedUpdate(){
      setDirectionOfMotion(objectInMotion.velocity);
      objectToRotate.transform.right = directionOfMotion; // will need to do some conversions here to get it to look properly in scene
    }

    private void setDirectionOfMotion(Vector3 input){
      directionOfMotion = input;
    }

    public void setObjectToRotate(GameObject input){
      objectToRotate = input;
    }
}
