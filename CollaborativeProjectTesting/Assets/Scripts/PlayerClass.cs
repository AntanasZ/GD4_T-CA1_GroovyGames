using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    [SerializeField]
    CharacterController controller;

    [SerializeField]
    private float playerSpeed = 12f;

    [SerializeField]
    private float gravity = -9.81f;

    [SerializeField]
    private Transform groundCheck;
    private float groundDistance = 0.4f; //radius of sphere for check
    [SerializeField]
    private LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * playerSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
