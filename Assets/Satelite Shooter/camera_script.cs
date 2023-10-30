using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    public static float screenLeft;
    public static float screenRight;
    public static float screenTop;
    public static float screenBottom;

    void Start()
    {
        float screenZ = -Camera.main.transform.position.z; // Assuming the camera is at (0, 0, 0) in the Z-axis.
        Vector3 screenLeftPos = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, screenZ));
        Vector3 screenRightPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, screenZ));
        Vector3 screenTopPos = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, screenZ));
        Vector3 screenBottomPos = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, screenZ));

        screenLeft = screenLeftPos.x;
        screenRight = screenRightPos.x;
        screenTop = screenTopPos.y;
        screenBottom = screenBottomPos.y;
    }
}
