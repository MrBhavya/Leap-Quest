
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    [SerializeField] private AudioSource dead;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            dead.Play();    
            FindObjectOfType<GameManager>().Endgame();
           
        }
    }
}