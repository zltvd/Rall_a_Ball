using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelections : MonoBehaviour
{
    public Image[] buttons;
    private void Start()
    {
        int curLVL = PlayerPrefs.GetInt("curLVL", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            if (PlayerPrefs.GetInt(i + "lvl", 0) >= 0)
                buttons[i].GetComponent<ButtonScript>().showStar(PlayerPrefs.GetInt(i + "lvl", 0));
            if (i + 1 > curLVL)
                buttons[i].GetComponent<Button>().interactable = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}

