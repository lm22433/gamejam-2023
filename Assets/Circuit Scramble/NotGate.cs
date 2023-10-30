using UnityEngine;

public class NotGate : LogicOutput
{
    public LogicOutput input;

    private void Update()
    {
        output = !input.GetOutput();
    }
}
