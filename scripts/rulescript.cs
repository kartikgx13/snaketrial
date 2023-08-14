using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rulescript : MonoBehaviour
{
    public void LoadHome()
    {
        SceneManager.LoadScene("menu");
    }
}
