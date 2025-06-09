using UnityEngine.SceneManagement;
using UnityEngine;

public class Ice_map : MonoBehaviour
{
    public void StartIceLevel()
    {
        SceneManager.LoadScene("Levelice");
    }

    public void ExitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
