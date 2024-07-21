using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load_scene2 : MonoBehaviour
{
    public Slider slider;
    private void Start()
    {
        StartCoroutine(LoadLevelAsinc());
    }
    private IEnumerator LoadLevelAsinc()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(0);
        while (!asyncLoad.isDone)
        {
            slider.value = asyncLoad.progress;
            yield return null;
        }
    }
}
