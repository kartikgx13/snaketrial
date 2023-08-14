using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject quitMenuUI;

   // public static bool check;

   // public static string sceneName;


    public void Start()
    {
       // Scene currentScene = SceneManager.GetActiveScene();
      //  sceneName = currentScene.name;
        //check = false;
        pauseMenuUI.SetActive(false);
        quitMenuUI.SetActive(false);
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        quitMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void HomeLoad()
    {
        SceneManager.LoadScene("menu");
    }

    

    public void quitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#endif
    }

    public void displayExit()
    {
        quitMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void backQuestion()
    {
        SceneManager.LoadScene("topics");
        Time.timeScale = 1f;
        gameIsPaused = false;
        //check = true;
        /*if (sceneName=="questiondisplay")
        {
            gameObject.GetComponent<snakemovement>().BackQuestionImage(); 
        }*/
    }

    
}
