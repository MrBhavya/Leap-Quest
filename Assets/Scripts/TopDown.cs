using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public float speed = 2f;
    private Rigidbody2D rb;
    private Transform current;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        current = A.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = current.position - transform.position;
        if (current == A.transform)
        {
            rb.velocity = new Vector2(0, speed);
        }
        else
        {
            rb.velocity = new Vector2(0, -speed);
        }

       if (Vector2.Distance(transform.position, current.position) < 0.5f && current == A.transform)
        {
            current = B.transform;
        }
        if (Vector2.Distance(transform.position, current.position) < 0.5f && current == B.transform)
        {
            current = A.transform;
        }
    }
}

