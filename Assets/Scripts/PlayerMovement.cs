using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float playerSpeed;

    public float playerRunningSpeed;

    public float gravity = -9.8f;


    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float JumpHeight = 3f;

    Vector3 velocity;

    
    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
       
        Vector3 direction = transform.right * x + transform.forward * z;
        //Vector3 move =  Vector3.right * x + Vector3.forward * z; 

        float PlayerSpeed = playerSpeed;
        if(Input.GetKey(KeyCode.LeftShift)){
            PlayerSpeed = playerRunningSpeed;
        }

        controller.Move(direction * PlayerSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

         if(gameObject.transform.position.y < 0){
            gravity = -7.8f;
         }


    }


void OnDrawGizmos() {
    Gizmos.DrawSphere(groundCheck.position, groundDistance);
}


}

