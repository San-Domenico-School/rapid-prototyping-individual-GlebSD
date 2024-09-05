using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Camera Controller holds cam on 3rd cam
 * 
 * By Gleb on 5th september V1
 * 
 * 
 */

public class CameraContoller : MonoBehaviour
{


    [SerializeField] private Transform vehicleTransform; // Holds the Transform component of the player
    private Vector3 offset; 

    // Holds the position vector that the camera will maintain from the player

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 8, -14);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowPlayer();

    }

    // Assigns the correct offset to the camera position
    private void FollowPlayer()
    {
        transform.position = vehicleTransform.position + offset;
    }

}
