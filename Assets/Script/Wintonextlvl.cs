using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Wintonextlvl : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 5f;
    public TMP_Text cText;
    public GameObject panel;
    public Image img0;
    public Image img1;
    public Image img2;
    public Image img3;
    void Start()
    {
        currentTime = startTime;
        img0.enabled = false;
        img1.enabled = false;
        img2.enabled = false;
        img3.enabled = false;
        Console.WriteLine("mew");

    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        cText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(4);
        }
    }
    public void Starss()
    {
        Move_sph move = gameObject.AddComponent<Move_sph>();
        int count = move.count;
        if (count >= 10)
        {
            img2.enabled = true;
        }
    }
}
