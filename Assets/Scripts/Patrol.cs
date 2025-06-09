using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public float speed = 1f;
    private Rigidbody2D rb;
    private Transform current;
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        current = A.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = current.position - transform.position;
        if( current == A.transform)
        {
            rb.velocity = new Vector2( -speed , 0);
        }
        else
        {
            rb.velocity = new Vector2( speed , 0);
        }

        if( Vector2.Distance(transform.position, current.position) < 0.5f && current == A.transform )
        {
            current = B.transform;
        }
        if (Vector2.Distance(transform.position, current.position) < 0.5f && current == B.transform)
        {
            current = A.transform;
        }   
    }
}
