using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject star1, star2, star3;
    
    public void showStar(int n)
    {
        if (n == 1)
            star1.SetActive(true);
        if (n == 2)
            star2.SetActive(true);
        if (n == 3)
            star3.SetActive(true);
    }
}
