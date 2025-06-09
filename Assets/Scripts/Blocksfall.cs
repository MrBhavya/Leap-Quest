using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocksfall : MonoBehaviour

{
    [SerializeField] private AudioSource drop;
    public GameObject obj1, obj2, obj3; 
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        drop.Play();
        obj1.GetComponent<Rigidbody2D>().gravityScale = 1;
        obj2.GetComponent<Rigidbody2D>().gravityScale = 1;
        obj3.GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
