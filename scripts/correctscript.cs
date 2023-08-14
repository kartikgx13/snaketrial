using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class correctscript : MonoBehaviour
{
    public void LoadTopics()
    {
        SceneManager.LoadScene("topics");
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("menu");
    }
}
