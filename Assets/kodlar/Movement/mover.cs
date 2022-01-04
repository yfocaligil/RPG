using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement 
{
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
        
        Updateanimator();
       
       
    }

    

    public void MoveTo(Vector3 hit)
    {
        GetComponent<NavMeshAgent>().destination = hit;
    }
}

}
