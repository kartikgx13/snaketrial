using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menumanager : MonoBehaviour
{

    public static bool gameIsPaused = false; 
    
    public GameObject quitMenuUI;

   

    public void Start()
    {
        quitMenuUI.SetActive(false);
        
    }

    public void Resume()
    {
        
        quitMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;

    }

    public void displayExit()
    {
        quitMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void quitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#endif
    }

    

}
