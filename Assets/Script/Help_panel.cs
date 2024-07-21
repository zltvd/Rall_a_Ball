using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help_panel : MonoBehaviour
{
    public GameObject panel_help;
    void Start()
    {
        panel_help.SetActive(false);
    }
    public void OnClick()
    {
        if (panel_help != null)
        {
            bool isActive = panel_help.activeSelf;
            panel_help.SetActive(!isActive);
        }
    }
}
