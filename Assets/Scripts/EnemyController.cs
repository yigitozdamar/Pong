using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Range(0,0.1f)]
    public float skill;

    public Rigidbody ball;
    
    void Start()
    {
                      
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = transform.position;
        newPos.z = Mathf.Lerp(transform.position.z, ball.transform.position.z, skill);
        transform.position = newPos;

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
