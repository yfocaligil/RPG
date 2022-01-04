using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement;
using RPG.Combat;

namespace RPG.Controller
{
public class PlayerController : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
        {
            if(InteractWithCombat()==true)
            {
                return;
            }
            if(InteractwithMovement()==true)
            {

            }
        }

        
        

        private bool InteractWithCombat()
        {
            
            RaycastHit[] hits=Physics.RaycastAll(GetMouseRay());
            foreach(RaycastHit hit in hits)
            {
                CombatTarget target =hit.transform.GetComponent<CombatTarget>();
                if(target==null)
                {
                    continue;
                }

                if(Input.GetMouseButtonDown(0))
                {
                    GetComponent<Fighter>().Attack(target);
                    
                }
                return true;
            }
            return false;
            
        }

        private bool InteractwithMovement()
        {
            Ray ray = GetMouseRay();
            RaycastHit hit;
            bool hasHit = Physics.Raycast(ray, out hit);
            if (hasHit == true)
            {
                if(Input.GetMouseButton(0))
                {
GetComponent<mover>().MoveTo(hit.point);
                }
                return true;
                
            }
            return false;
        }

        private static Ray GetMouseRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
}

