using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public GameObject btnMusicOff;
    public AudioSource audioSource;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void AudioOff()
    {
        audioSource.Stop();
        btnMusicOff.gameObject.SetActive(true);
    }

    public void AudioOn()
    {
        audioSource.Play();
        btnMusicOff.gameObject.SetActive(false);
    }
}
