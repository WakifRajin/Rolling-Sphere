using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        public Rigidbody rb;

    public float ForwardForce = 100f;
    public float SideForce = 50f;
    //public float JumpForce = 5f;


    /*private bool isGrounded;

    
       return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
       
    } */

        
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime); //adding a force towards z direction

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //adding a force towards x axis
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //adding a force towards -x axis
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManagerScript>().GameOver();
        }

        /* if (isGrounded() && Input.GetKey("w"))
         {
             rb.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange); //adding a force towards x axis
         }

        if (isGrounded == true && Input.GetKey("w"))
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            isGrounded = false;
        }

        void OnCollisionEnter()
        {
            isGrounded = true;
        } */
    }
}
