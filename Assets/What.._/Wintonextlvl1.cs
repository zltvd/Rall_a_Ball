using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Wintonextlvl1 : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 5f;
    public TMP_Text cText;
    public GameObject panel;
    void Start()
    {
        currentTime = startTime;  
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        cText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(3);
        }
        
    }
}
