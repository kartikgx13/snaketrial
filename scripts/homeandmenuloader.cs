using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeandmenuloader : MonoBehaviour
{
   public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void LoadTopics()
    {
        SceneManager.LoadScene("topics");
    }
}
