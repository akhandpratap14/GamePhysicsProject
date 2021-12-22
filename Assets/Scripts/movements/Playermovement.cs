using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public CharacterController controller;
    public float sprintspeed = 20f;
    public float currentspeed;
    public float normalspeed = 3f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public bool isSprinting = false;
    
    Vector3 velocity;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }

        
        if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

        if (isSprinting == true)
        {
            currentspeed = sprintspeed;
        }
        else
        {
            currentspeed = normalspeed;
        }
         float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(move * currentspeed * Time.deltaTime);

            //jump
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

       

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        
    }
}
