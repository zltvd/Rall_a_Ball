using UnityEngine;
using UnityEngine.SceneManagement;
public class Win_scr1 : MonoBehaviour
{
    public GameObject panel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player") == true)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void mew()
    {
        SceneManager.LoadScene(4);
        Global.nxtLevel = 3;
        if (Global.nxtLevel > PlayerPrefs.GetInt("curLVL"))
            PlayerPrefs.SetInt("curLVL", Global.nxtLevel);
    }
}
