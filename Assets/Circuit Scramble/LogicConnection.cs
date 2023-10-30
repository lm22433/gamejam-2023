using System;
using UnityEngine;

public class LogicConnection : MonoBehaviour
{
    public LogicOutput input;
    public Transform output;

    private LineRenderer _lineRenderer;

    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();

        _lineRenderer.SetPosition(0, input.transform.position);
        _lineRenderer.SetPosition(1, output.position);

        _lineRenderer.endWidth = 0.1f;
        _lineRenderer.startWidth = 0.1f;

        _lineRenderer.startColor = input.GetOutput() ? Color.green : Color.red;
        _lineRenderer.endColor = input.GetOutput() ? Color.green : Color.red;
    }

    private void Update()
    {
        _lineRenderer.startColor = input.GetOutput() ? Color.green : Color.red;
        _lineRenderer.endColor = input.GetOutput() ? Color.green : Color.red;
    }
}
