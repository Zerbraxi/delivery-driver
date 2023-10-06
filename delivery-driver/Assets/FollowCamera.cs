using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/** The purpose of this to have the MainCamera's position 
*   follow the position of the car (carL)
*/
public class FollowCamera : MonoBehaviour
{

    // Reference to link to car (carL)
    [SerializeField] GameObject thingToFollow;

    // LateUpdate() executes at the end of the Update logic
    // Should help smooth camera movement
    void LateUpdate()
    {
        
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);

    }
}
