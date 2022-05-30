using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 10f;
    public float run = 20f;
    public CharacterController playerController;
    Vector3 move;
    Vector3 velocity;
    public float gravity = -22f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHight = 3f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (isGrounded == true)
        {
            move = transform.right * horizontal + transform.forward * vertical;
        }
        
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded == true)
        {
            playerController.Move(move * run * Time.deltaTime);
        }
        else
        {
            playerController.Move(move * speed * Time.deltaTime);
        }
        

        velocity.y += gravity * Time.deltaTime;
        playerController.Move(velocity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                velocity.y = Mathf.Sqrt(jumpHight * -2 * gravity);
            }
        }
    }
}
