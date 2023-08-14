using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class topicmanager : MonoBehaviour
{
   public void LoadHome()
    {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        
        
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;

#endif
        
    }

    public void Bodmas()
    {
        SceneManager.LoadScene("bodmas");
    }

    public void LinearAlgebra()
    {
        SceneManager.LoadScene("linear algebra");
    }

    public void MentalAbility()
    {
        SceneManager.LoadScene("mental ability");
    }

    public void AreaAndVolume()
    {
        SceneManager.LoadScene("area and volume");
    }
}
