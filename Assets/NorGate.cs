using UnityEngine;

public class NorGate : LogicOutput
{
    public LogicOutput inputA;
    public LogicOutput inputB;

    private void Update()
    {
        output = !(inputA.GetOutput() || inputB.GetOutput());
    }
}
