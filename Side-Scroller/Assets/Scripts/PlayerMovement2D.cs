using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, 0);

        rb.velocity = new Vector2(movement.x, rb.velocity.y);
    }
}
