using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private Rigidbody rb;
    private bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayer);
        Debug.DrawLine(transform.position, groundCheck.position, Color.red);

        if (grounded == true)
            canJump = true;
        else
            canJump = false;


        Jump();

       
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && canJump == true)
        {
            canJump = false;
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
