using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LrTesting2 : MonoBehaviour

// draw pink lines across higher level

// scripts attached to main camera, so which points to connect defined on main camera speculator)
{

    [SerializeField] private Transform[] points;
    [SerializeField] private DrawLine line;

    private void Start()
    {
        line.SetUpLine(points);
    }
}
