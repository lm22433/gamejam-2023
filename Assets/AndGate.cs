using UnityEngine;

public class AndGate : LogicOutput
{
    public LogicOutput inputA;
    public LogicOutput inputB;

    private void Update()
    {
        output = inputA.GetOutput() && inputB.GetOutput();
    }
}
