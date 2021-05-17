using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : Click
{

    public Vector3  pointA;


    // Start is called before the first frame update
    void Start()
    {

      
        //mode one
        // Random pointA in the ring area_1 (the ring: clickpoint as ring centre with 3<r<9 )

        pointA = targetPosition + new Vector3(Random.Range(3f, 9f), 0f, Random.Range(0f, -9f));
            this.transform.position = Vector3.MoveTowards(transform.position, pointA, speed * Time.deltaTime);



        //mode two
        // the opposite inclined direction 
        // Random pointA in the ring area_3 (the ring: clickpoint as ring centre with 3<r<9 )
        //pointA = targetPosition + new Vector3(Random.Range(0f, 9f), 0f, Random.Range(3f, 9f));
        //this.transform.position = Vector3.MoveTowards(transform.position, pointA, speed * Time.deltaTime);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
