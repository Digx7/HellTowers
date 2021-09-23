using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ViewRange : MonoBehaviour
{
    [SerializeField] private bool isRendered;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private Color color;

    [SerializeField] private FloatType radius;
    [SerializeField] private IntegerType defaultVertCount;
    [SerializeField] private float xRadius;
    [SerializeField] private float zRadius;

    public bool IsRendered { get => isRendered; set => isRendered = value; }
    public float XRadius { get => xRadius; set => xRadius = value; }
    public float ZRadius { get => zRadius; set => zRadius = value; }

    private void Start()
    {
        if (isRendered)
        {
            lineRenderer.positionCount = defaultVertCount.Value + 1;
            lineRenderer.useWorldSpace = false;
            CreatePoints();
        }
    }

    private void Update()
    {
        
    }


    void CreatePoints() // from: https://gamedev.stackexchange.com/a/126429
    {
        float x;
        float y;
        float z;

        float angle = 20f;

        for (int i = 0; i < (this.defaultVertCount.Value + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * this.XRadius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * this.ZRadius;

            lineRenderer.SetPosition(i, new Vector3(x, 0, z));

            angle += (360f / this.defaultVertCount.Value);
        }
    }
}
