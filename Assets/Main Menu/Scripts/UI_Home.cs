using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Home : MonoBehaviour
{
    public void OnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }
}
