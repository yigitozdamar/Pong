using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float mouseInput;
    public Rigidbody playerRb;
    public float speed = 15.0f;
    public float sensitivity = 5.0f;

    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        //Keyboard Controller
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * -horizontalInput * speed * Time.deltaTime);
        //Mouse Controller
        mouseInput = Input.GetAxis("Mouse Y");
        transform.Translate(Vector3.forward * mouseInput * speed * Time.deltaTime * sensitivity );


        // Stay In Bounds
        if (transform.position.z > 15)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 15);
        }
        else if (transform.position.z < -15)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -15);
        }
    }
}
