using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLoaderscript : MonoBehaviour
{
    public Button startButton;

    public Animator transition;

    public float transitiontime = 1f;

    

    public void Update()
    {
        startButton.onClick.AddListener(LoadNextLevel);
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(levelIndex);
    }

    public void check()
    {
        Debug.Log("Chal raha hai bhai");
    }
}
