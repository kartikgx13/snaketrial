using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuscript : MonoBehaviour
{
   public void startGame()
    {
        SceneManager.LoadScene("topics");
    }

    public void info()
    {
        SceneManager.LoadScene("infoscene");
    }

    public void settings()
    {
        SceneManager.LoadScene("settingscene");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("how to play scene");
    }



}
