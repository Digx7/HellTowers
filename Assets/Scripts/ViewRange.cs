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

    public bool IsRendered { get => isRendered; set => isRendered = value; }
    public FloatType Radius { get => radius; set => radius = value; }

    private void Start()
    {
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
        lineRenderer.enabled = true;
        lineRenderer.positionCount = defaultVertCount.Value + 1;
        lineRenderer.useWorldSpace = false;
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;
        CreatePoints();
    }    
    void CreatePoints() // from: https://gamedev.stackexchange.com/a/126429
    {
        float x;
        float y;
        float z;

        float angle = 20f;

        for (int i = 0; i < (this.defaultVertCount.Value + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * this.Radius.Value;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * this.Radius.Value;

            lineRenderer.SetPosition(i, new Vector3(x, 0, z));

            angle += (360f / this.defaultVertCount.Value);
        }
    }
}