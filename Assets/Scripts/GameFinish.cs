
using UnityEngine;
using UnityEngine.UI;

public class GameFinish : MonoBehaviour
{
    public GameObject butt, img , pause , home;
    public bool reached;
    [SerializeField] AudioSource win;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        butt.SetActive(true);
        reached = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        butt.SetActive(false);
        reached = false;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& reached == true) 
        {
            win.Play(); 
            img.SetActive(true);
            Time.timeScale = 0f;
            pause.SetActive(false);
            home.SetActive(true);
        }
    }
}
