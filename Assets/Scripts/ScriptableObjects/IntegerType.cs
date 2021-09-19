using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntegerType : ScriptableObject
{
    [SerializeField] private int value;

    public int Value { get => value; set => this.value = value; }
}
