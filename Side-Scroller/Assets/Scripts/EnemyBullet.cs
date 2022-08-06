using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifeSpan;

    private Rigidbody rb;

    private PlayerHealth playerHealthScript;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * bulletSpeed);

        Invoke("Delete", bulletLifeSpan);
    }

    private void Delete()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerHealthScript = collision.gameObject.GetComponent<PlayerHealth>();

            playerHealthScript.health--;

            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
