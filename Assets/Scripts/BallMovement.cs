using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),
                                0,
                                Input.GetAxis("Vertical")) * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("Coin Collected!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            Destroy(gameObject);
            Debug.Log("You are Dead.");
        }

        else if(collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
            Debug.Log("You are Dead.");
        }
    }
}
