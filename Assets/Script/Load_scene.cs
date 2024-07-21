using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load_scene : MonoBehaviour
{
    public Slider slider;
    public void neext()
    {
        SceneManager.LoadScene(Global.nxtLevel);
    }
}
