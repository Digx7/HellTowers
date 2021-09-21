using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRangeHUD : MonoBehaviour
{
    [SerializeField] private bool showViewRangeHUD;

    private void Start()
    {
        if (showViewRangeHUD == true)
        {
            // then make sure we draw the HUD
        }
    }
}
