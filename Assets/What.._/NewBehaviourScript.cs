using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Image[] buttons; 
    private void Start()
    {
        int curLVL = PlayerPrefs.GetInt("curLVL", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i + 1 > curLVL)
                buttons[i].GetComponent<Button>().interactable = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
