using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{

    public void StartButton()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenuScene");
    }

}
