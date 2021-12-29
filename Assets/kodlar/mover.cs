using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class mover : MonoBehaviour
{
    

 
    void Start()
    {
        
    }

private void Updateanimator()
{
Vector3 velocity=GetComponent<NavMeshAgent>().velocity;
Vector3 localvelocity=transform.InverseTransformDirection(velocity);
float speed=localvelocity.z;
GetComponent<Animator>().SetFloat("forwardSpeed",speed);
}
    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
       Movetocursor();
       
        }
        Updateanimator();
       
       
    }

    private void Movetocursor()
    {
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit=Physics.Raycast(ray, out hit);
        if(hasHit==true)
        {
            GetComponent<NavMeshAgent>().destination=hit.point;
        }
    }
}
