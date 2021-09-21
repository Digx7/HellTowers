using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolType : ScriptableObject
{
    [SerializeField] private bool value;

    public bool Value { get => value; set => this.value = value; }
}
