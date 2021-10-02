using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpVelocity;

    private bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("w") && isGrounded)
      {
            rb.velocity = Vector3.up * jumpVelocity;
            isGrounded = false;
        }
    }
    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}