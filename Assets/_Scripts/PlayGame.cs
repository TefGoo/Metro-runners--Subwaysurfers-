using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void Menu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Skinshop()
    {
        SceneManager.LoadScene("Store");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game...");
    }

}



