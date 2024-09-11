using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/**************************************
 * Components of the Main Camera thats keps it 
 * a constan distance from the vehicle
 * 
 * Gleb
 * 11 september version 1
 * 
 */
public class PlayerController : MonoBehaviour
{

    private float speed; //hold forw
    private float turnspeed; // holds turn
    private float verticalInput;// value from user W/s
    private float horizontalinput;// value form user A/S
    private Rigidbody rb;//RIGID BODY COMPONENT


    [SerializeField] private Transform vehicleTransform; // Holds the Transform component of the player
    private Vector3 offset;                              // Holds the position vector that the camera will maintain from the play


    // Start is called before the first frame update
    void Start()
    {
        speed = 20.0f;
        turnspeed = 30.0F;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        rb.AddRelativeForce(Vector3.forward * speed * rb.mass * verticalInput);
        transform.Rotate(Vector3.up * turnspeed * horizontalinput * Time.deltaTime);
    }

    private void OnMove(InputValue inputValue)
    {
        
        Vector2 inputVector = inputValue.Get<Vector2>();
        verticalInput = inputVector.y;
        horizontalinput = inputVector.x;
    }

}
