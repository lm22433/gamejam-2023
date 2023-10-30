using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Jarvis_Camera;



    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraJarvis();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraMain();
        }


    }

    void CameraJarvis()
    {
        Jarvis_Camera.SetActive(true);
        MainCamera.SetActive(false);

    }

    void CameraMain()
    {
        Jarvis_Camera.SetActive(false);
        MainCamera.SetActive(true);

    }
}
