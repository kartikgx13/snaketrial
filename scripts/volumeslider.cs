using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeslider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public static bool gameIsPaused = false;

    public GameObject volumeMenuUI;

    public void Start()
    {
        volumeMenuUI.SetActive(false);

        if (!PlayerPrefs.HasKey("musicVolume")) 
        {
            PlayerPrefs.SetFloat("musicVolume",1);
            LoadVolume();
        }
       else
        {
            LoadVolume();
        }
    }

        public void Resume()
    {

        volumeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;

    }

    public void DisplayVolume()
    {
        volumeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        save();
    }
    public void LoadVolume()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    public void save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

   
}
