using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Which_lcl : MonoBehaviour
{
    public void lvlSel(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }
}
