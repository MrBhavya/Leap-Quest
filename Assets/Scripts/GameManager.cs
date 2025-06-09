using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isEnded = false; // Tracks if the game has already ended
    public GameFinish fin; // Placeholder for other game finish logic
    public GameObject img; // Placeholder for UI image or similar object

    public void Endgame()
    {
        if (!isEnded) // Check if the game has not ended
        {
            // Get the current active scene
            Scene currentScene = SceneManager.GetActiveScene(); // This is now a local variable

            // Reload the current scene
            SceneManager.LoadScene(currentScene.name);

            // Mark the game as ended
            isEnded = true;
        }
    }
}
