using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    void Start()
    {
        
    }

    
    void lateupdate()
    {
        transform.position=player.position;
    }
}
}

