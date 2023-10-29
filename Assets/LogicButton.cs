using UnityEngine;

public class BooleanButton : LogicOutput
{
    public void ToggleOutput()
    {
        output = !output;
    }
}
