using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class infoscript : MonoBehaviour
{
   public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
