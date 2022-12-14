using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Exit : MonoBehaviour
{
    AudioSource audioSource;

    IEnumerator Next()
    {
        audioSource.Play(); yield return new WaitForSecondsRealtime(0.8f);
        Save.savedScene = SceneManager.GetActiveScene().name; SceneManager.LoadScene("Main Menu");
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        StartCoroutine("Next");
    }
}
