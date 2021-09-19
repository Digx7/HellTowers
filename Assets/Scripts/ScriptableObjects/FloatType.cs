using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatType : ScriptableObject
{
    [SerializeField] private float value;

    public float Value { get => value; set => this.value = value; }
}
