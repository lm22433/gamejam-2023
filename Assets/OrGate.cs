using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrGate : LogicOutput
{
    public LogicOutput inputA;
    public LogicOutput inputB;

    private void Update()
    {
        output = inputA.GetOutput() || inputB.GetOutput();
    }
}
