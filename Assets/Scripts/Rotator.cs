using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector2 rotationDirection;

    public void RotatePlayer(Vector2 input){
      if (input.x != 0 || input.y != 0) {
          float angle = Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg;
          this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
      }
    }
}
