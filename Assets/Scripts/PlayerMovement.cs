using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 4f;

    public static int score = 0;
    [SerializeField] Text scoreTxt;
    
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetButtonDown("Jump")) {Jump();}

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
    }
    
    
    // Kill enemies
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy head"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
            // ADD 1 point
            score++;
            scoreTxt.text = score.ToString();
        }
    }
    
    
}
