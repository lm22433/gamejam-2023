using System;
using UnityEngine;

public class NandGate : LogicOutput
{
    public LogicOutput inputA;
    public LogicOutput inputB;

    private void Update()
    {
        output = !(inputA.GetOutput() && inputB.GetOutput());
    }
}
