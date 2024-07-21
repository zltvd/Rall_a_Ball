using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loose_scr : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") == true)
        {
            FindObjectOfType<AudioManager>().Play("lose");
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void Start()
    {
        panel.SetActive(false);
    }
}
