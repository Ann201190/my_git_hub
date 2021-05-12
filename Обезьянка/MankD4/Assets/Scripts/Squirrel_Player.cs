using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirrel_Player : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }
        else {
            horizontal = Input.GetAxis("Horizontal");
        }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")* 10f, rb.velocity.y);

        transform.rotation = new Quaternion(0, 0, 0, 0);
        //transform.Rotate(0.0f, 0.0f, 0.0f);
    }

    void FixedUdate()
    {
       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up * 20, ForceMode2D.Impulse);
        }
    }
}
