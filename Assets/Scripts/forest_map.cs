using UnityEngine.SceneManagement;
using UnityEngine;

public class Startmenuice : MonoBehaviour
{

    public void star()
    {
        SceneManager.LoadScene("Level");
    }

    public void Exitgame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }


}
