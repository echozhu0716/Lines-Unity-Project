using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click : MonoBehaviour
{

    
    public Vector3 targetPosition ;
    public float speed = 1000f;




    // get mouse left click position to drag clickpoint
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetTargetPosition();
        }
    }

 
    public void SetTargetPosition()
    {


        // set a raycast hit on screen
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // drag clickpoint to the next hit position
        if (Physics.Raycast(ray,out hit, 1000))
        {
           targetPosition = hit.point;
           this.transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
           


        }
    }



 
}
