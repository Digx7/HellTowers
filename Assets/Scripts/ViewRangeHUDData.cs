using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute]
public class ViewRangeHUDData : ScriptableObject
{
    [SerializeField] private BoolType isVisible;
    [SerializeField] private IntegerType viewRadius;
    [SerializeField] private Color rangeHUDColor;

    public BoolType IsVisible { get => isVisible; set => isVisible = value; }
    public IntegerType ViewRadius { get => viewRadius; set => viewRadius = value; }
    public Color RangeHUDColor { get => rangeHUDColor; set => rangeHUDColor = value; }

}
