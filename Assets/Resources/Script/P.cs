using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : Click 
{
    public Vector3  pointP;


    void Start()
    {
        {
            // Second floor point, , y =12
            pointP = new Vector3(Random.Range(-3f, 0f), 12f, Random.Range(0f, 3f));
            this.transform.position = Vector3.MoveTowards(transform.position, targetPosition + pointP, speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
