using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class desroyerr : MonoBehaviour
{
    public Transform posi;
    [SerializeField] private GameObject obj;

    private Rigidbody2D rb;

    void Start()
    {
        // Cache the Rigidbody2D component
        rb = obj.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody2D attached to the object!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (posi.position.y < -12f)
        {
            Destroy(obj);
        }
    }

    // FixedUpdate is called for physics interactions
    void FixedUpdate()
    {
        if (rb != null)
        {
            // Apply a slow force to the left
            rb.AddForce(Vector2.right * 1.5f, ForceMode2D.Force);
        }
    }
}
