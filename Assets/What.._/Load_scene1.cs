using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load_scene1: MonoBehaviour
{
    public Slider slider;
    public int nextLVL = 4;
    private void Start()
    {
        SceneManager.LoadScene(Global.nxtLevel);
    }

    private IEnumerator LoadLevelAsinc()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextLVL);
        while (!asyncLoad.isDone)
        {
            slider.value = asyncLoad.progress;
            yield return null;
        }
    }
}
