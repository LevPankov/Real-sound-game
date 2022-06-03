using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 10f;
    public float run = 10f;
    public CharacterController playerController;
    Vector3 move;
    Vector3 velocity;
    public float gravity = -22f;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHight = 3f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (playerController.isGrounded)
        {
            move = transform.right * horizontal + transform.forward * vertical;
        }
        
        if (Input.GetKey(KeyCode.LeftShift) && playerController.isGrounded)
        {
            playerController.Move(move * run * Time.deltaTime);
        }
        else
        {
            playerController.Move(move * speed * Time.deltaTime);
        }
        

        velocity.y += gravity * Time.deltaTime;
        playerController.Move(velocity * Time.deltaTime);

        if (playerController.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerController.isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHight * -2 * gravity);
            }
        }
    }
}
