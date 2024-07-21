using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_panelsss : MonoBehaviour
{
    public void ShowMenu(GameObject menu)
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume(GameObject menu)
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("button");
        SceneManager.LoadScene(4);
        Global.nxtLevel = 0;
    }
    public void Exit()
    {
        FindObjectOfType<AudioManager>().Play("button");
        Time.timeScale = 1f;
        Application.Quit(0);
    }
}
