using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : Click
{
    public Vector3 pointF;


    void Start()
    {
        {
            // third floor point , y =24
            pointF = new Vector3(Random.Range(-3f, 0f), 24f, Random.Range(0f, 3f));
            this.transform.position = Vector3.MoveTowards(transform.position, targetPosition + pointF, speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

