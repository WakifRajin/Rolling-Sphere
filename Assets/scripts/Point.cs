using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int points = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100,20), "Points:  " + points);
    }
}
