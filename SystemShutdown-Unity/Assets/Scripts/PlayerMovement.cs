/* Created by: Kameron Eaton
 * Date Created: April 7, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 13, 2022
 * 
 * Description: Allows the player to move around with keyboard inputs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float crouchHeight = 2f;
    public float standingHeight = 3.8f;
    public float crouchingMultiplier;
    public float crouchYScale;
    float startYScale;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Transform headCheck;
    public float ceilingDistance = 1.5f;

    Vector3 velocity;
    bool isGrounded;
    bool isCrouching;
    bool stayCrouched;

    private void Start()
    {
        startYScale = transform.localScale.y;
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        stayCrouched = Physics.CheckSphere(headCheck.position, ceilingDistance, groundMask);

        if(isGrounded & velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Crouch();
        }//end if(Input.GetKeyDown(KeyCode.LeftControl))

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }//end if(Input.GetKeyDown(KeyCode.Space) && isGrounded)

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }//end Update

    void Crouch()
    {
        if (isCrouching)
        {
            if (stayCrouched)
                return;
            isCrouching = false;
            transform.localScale = new Vector3(transform.localScale.x, startYScale, transform.localScale.z);
            speed /= crouchingMultiplier;
            
        }
        else
        {
            isCrouching = true;
            transform.localScale = new Vector3(transform.localScale.y, crouchYScale, transform.localScale.z);
            speed *= crouchingMultiplier;
        }
    }
}//end PlayerMovement
