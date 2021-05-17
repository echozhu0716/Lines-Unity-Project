using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;



    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }


    //connecting points (this fuction was used in lrtesting and lrtesting2, 
    //..., and lrtesting and lrtesting2 are attached to main camera, so which points to connect defined on main camera speculator)
    public void SetUpLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
    }

    private void Update()
    {
        //with the loop here,  lines act with points dynamically
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }




    //// Start is called before the first frame update
    //void Start()

    //{

    //    lineRenderer = GetComponent<LineRenderer>();
    //    lineRenderer.SetPosition(0, pointA.transform.position);

    //    distance = Vector3.Distance(pointA.transform.position, pointP.transform.position);


    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (counter < distance)
    //    {
    //        counter += .1f / drawLineSpeed;
    //        float x = Mathf.Lerp(0, distance, counter);

    //        Vector3 pointAlongLine = x * Vector3.Normalize(pointP.transform.position - pointA.transform.position) + pointA.transform.position;
    //        lineRenderer.SetPosition(1, pointAlongLine);




    //    }

    //}
}

