using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()  // Update is called once per frame
    {
          // Pause/Resume based on pause key pressed
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            { Resume(); }
            else
            { Pause(); }
        }

    }

    public void Resume()  // Resumes game & removes pause menu
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()  // Stops game & activates pause menu
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()  // Loads main menu
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Loading menu...");
    }

    public void QuitGame()  // Quits game
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

}
