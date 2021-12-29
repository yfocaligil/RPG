using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    void Start()
    {
        
    }

    
    void lateUpdate()
    {
        transform.position=player.position;
    }
}
