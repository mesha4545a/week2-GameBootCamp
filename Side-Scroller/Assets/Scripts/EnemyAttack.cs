/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            rb = player.GetComponent<Rigidbody>();

            playerScript = player.GetComponent<PlayerMovement2D>();

            PushPlayer();
        }
    }

    private void PushPlayer()
    {
        
    }
    
}*/
