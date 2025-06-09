using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public bool isPaused = false; // Tracks if the game is paused
    public GameObject ui; // The pause menu UI

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // Resumes the game
    public void Resume()
    {
        ui.SetActive(false); // Hide pause menu
        Time.timeScale = 1f; // Resume time
        isPaused = false;
    }

    // Pauses the game
    public void Pause()
    {
        ui.SetActive(true); // Show pause menu
        Time.timeScale = 0f; // Freeze time
        isPaused = true;
    }

    // Reloads the current scene
    public void Reload()
    {
        Time.timeScale = 1f; // Resume time before reloading
        Scene currentScene = SceneManager.GetActiveScene(); // Get the current scene
        SceneManager.LoadScene(currentScene.name); // Reload the current scene
    }

    // Loads the homepage scene
    public void Homepage()
    {
        Time.timeScale = 1f; // Resume time
        SceneManager.LoadScene("Homepage"); // Load the homepage scene
    }
}
