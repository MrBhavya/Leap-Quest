using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obj;
    public bool isspawned = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && isspawned == false)
        {
            obj.SetActive(true);
            isspawned = true;
        }

        
    }

}
