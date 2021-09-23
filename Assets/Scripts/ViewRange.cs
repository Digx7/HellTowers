using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(LineRenderer))]
public class ViewRange : MonoBehaviour
{
    [SerializeField] private bool isRendered;
    
    [SerializeField] private Color materialColor;

    [SerializeField] private FloatType radius;
    private float minRadius = 0;
    private float maxRadius = 500;


    [SerializeField] private IntegerType vertCount;
    private int minVertCount = 0;
    private int maxVertCount = 100;


    [SerializeField] private LineRenderer lineRenderer;


    
    

    public bool IsRendered { get => isRendered; set => isRendered = value; }
    public FloatType Radius { get => radius; set => radius = value; }
    public Color MaterialColor { get => materialColor; set => materialColor = value; }

    private void Awake()
    {
        if (isRendered)
        {            
            RenderCircle();

        }
    }

    private void OnValidate()
    {
        ClampProperties();
    }

    private void Update()
    {
        // there has absolutely got to be a better way to do this.
        // that being said, this is how I'm doing it for the time being.
        // TODO Come back to this
        if(!isRendered)
        {
            lineRenderer.enabled = false;
        }
        else
        {
            RenderCircle();
        }
    }

    void RenderCircle()
    {
        ClampProperties();
        lineRenderer.enabled = true;
        lineRenderer.loop = true;
        lineRenderer.positionCount = vertCount.Value + 1;
        lineRenderer.useWorldSpace = false;
        lineRenderer.material.color = MaterialColor;
        CreatePoints();
    }    
    void CreatePoints() // from: https://gamedev.stackexchange.com/a/126429
    {
        float x;
        float y;
        float z;

        float angle = 20f;

        for (int i = 0; i < (this.vertCount.Value + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * this.Radius.Value;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * this.Radius.Value;

            lineRenderer.SetPosition(i, new Vector3(x, 0, z));

            angle += (360f / this.vertCount.Value);
        }
    }

    void ClampProperties()
    {
        radius.Value = Mathf.Clamp(radius.Value, minRadius, maxRadius); // or int.MaxValue, if you need to use an int but can't use uint.
        vertCount.Value = Mathf.Clamp(vertCount.Value, minVertCount, maxVertCount);
    }
}
