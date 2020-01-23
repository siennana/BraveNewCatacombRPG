using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButton : MonoBehaviour
{
    void OnGUI()
    {
        Color c = GUI.backgroundColor;
        GUI.backgroundColor = Color.clear;

        GUI.Label(new Rect(10f, 30f, 300f, 50f), "1.Print the alphabet image targets located at");
        GUI.Label(new Rect(10f, 60f, 300f, 50f), "2.Point any of the animal images");
        GUI.Label(new Rect(10f, 100f, 300f, 50f), "3.Finally your kids able to see the 3D animal render on the screen with soundss");

        if (GUI.Button(new Rect(260, 15, 120, 50), "www.serverurl.net"))
        {
            Application.OpenURL("http://www.serverurl.net");
        }

        GUI.backgroundColor = c;

        if (GUI.Button(new Rect(80, 180, 80, 40), "start"))
        {
        
        }
    }
}
