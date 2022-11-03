using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // func Move Scene
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
        Debug.Log("Berpindah scene");
    }

    // func Author
    public void OpenAuthor()
    {
        Debug.Log("Create By Pikaruo, hohoho");
    }

    // func Quit Game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Keluar game");
    }
}
