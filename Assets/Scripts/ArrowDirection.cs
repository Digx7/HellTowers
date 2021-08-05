using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ComboDirection {up,down,left,right};

[System.Serializable]
public class ArrowDirection
{
  public ComboDirection chosenDirection;
}
