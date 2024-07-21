using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class UIscr : MonoBehaviour
{
    public GameObject levelSelection;
    public void Start()
    {
        levelSelection.SetActive(false);
    }
    public void main_start(Button Start)
    {
        EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
        if (levelSelection.activeSelf == true)
            levelSelection.SetActive(false);
        else 
            levelSelection.SetActive(true);
    }
    public void levelSelectionHide()
    {
        levelSelection.SetActive(false);
    }
    public void main_quit()
    {
        Application.Quit();
    }
    public void lvlSelect(int lvl)
    {
        FindObjectOfType<AudioManager>().Play("button");
        SceneManager.LoadScene(4);
        Global.nxtLevel = lvl;
    }
}
