using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : Click 
{
    public Vector3 pointB;


    // Start is called before the first frame update
    void Start()
    {


        {

            //mode one
            // Random pointB in the ring area_2 (the ring: clickpoint as ring centre with 3<r<9 )
            pointB = new Vector3(Random.Range(-9f, 0f), 0f, Random.Range(-9f, -3f));
            this.transform.position = Vector3.MoveTowards(transform.position, targetPosition + pointB, speed * Time.deltaTime);


            //mode two
            // the opposite inclined direction 
            // Random pointB in the ring area_4 (the ring: clickpoint as ring centre with 3<r<9 )
            //pointB = new Vector3(Random.Range(-9f, -3f), 0f, Random.Range(0f, 9f));
            //this.transform.position = Vector3.MoveTowards(transform.position, targetPosition + pointB, speed * Time.deltaTime);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
