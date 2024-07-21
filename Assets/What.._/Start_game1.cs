using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEditor.Experimental.GraphView;
using UnityEngine.SceneManagement;

public class St_g_lvl2 : MonoBehaviour
{
    //public GameObject panel_start;
    public GameObject panel_pause;
    public GameObject panel_win;
    public GameObject panel_lose;
    private int sec = 0;
    private int min = 0;
    private TMP_Text timer;
    private int delta = 0;
    void Start()
    {
        panel_pause.SetActive(false);
        panel_lose.SetActive(false);
        Time.timeScale = 0f;
        delta = 1;
    }
    //public void start()
    //{
    //    timer = GameObject.Find("Time").GetComponent<TMP_Text>();
    //    StartCoroutine(TimerFlow());
    //    panel_start.SetActive(false);
    //    Time.timeScale = 1f;
    //}
    IEnumerator TimerFlow()
    {
        while (true)
        {
            if (sec == 59)
            {
                min++;
                sec = -1;
            }
            sec += delta;
            timer.text = "Time: " + min.ToString("D2") + " : " + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
    public void StartStop(int delta)
    {
        this.delta = delta;
    }
    public void pause()
    {
        panel_pause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void start_two()
    {
        panel_pause.SetActive(false);
        Time.timeScale = 1f;
    }
    public void next_lvl()
    {
        panel_win.SetActive(false);
        //SceneManager.LoadScene(0);
        //panel_start.SetActive(false);
        Time.timeScale = 1f;
    }
    public void reatart_lvl()
    {
        panel_lose.SetActive(false);
        //SceneManager.LoadScene(0);
        //panel_start.SetActive(false);
        Time.timeScale = 1f;
    }
}
