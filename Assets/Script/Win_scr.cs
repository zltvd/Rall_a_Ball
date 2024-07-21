using UnityEngine;
using UnityEngine.SceneManagement;
public class Win_scr : MonoBehaviour
{
    public GameObject panel;
    public int currentLVL;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.CompareTag("Player") == true)
        {
            FindObjectOfType<AudioManager>().Play("win");
            panel.SetActive(true);
            Time.timeScale = 0f;

            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                if (Global_star.nxtStar > 8)
                {
                    if (Global_star.nxtStar == 16)
                    {
                        PlayerPrefs.SetInt(currentLVL + "lvl", 3);
                    }
                    if (Global_star.nxtStar <= 15)
                    {
                        PlayerPrefs.SetInt(currentLVL + "lvl", 2);
                    }
                }
                if (Global_star.nxtStar <= 8 )
                {
                    PlayerPrefs.SetInt(currentLVL + "lvl", 1);
                }
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                if (Global_star.nxtStar > 5)
                {
                    if (Global_star.nxtStar == 10)
                    {
                        PlayerPrefs.SetInt(currentLVL + "lvl", 3);
                    }
                    if (Global_star.nxtStar <= 9)
                    {
                        PlayerPrefs.SetInt(currentLVL + "lvl", 2);
                    }
                }
                if (Global_star.nxtStar <= 5)
                {
                    PlayerPrefs.SetInt(currentLVL + "lvl", 1);
                }
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {

                if (Global_star.nxtStar > 5)
                {
                    if (Global_star.nxtStar == 10)
                    {
                        
                        PlayerPrefs.SetInt(currentLVL + "lvl", 3);
                    }
                    if (Global_star.nxtStar <= 9)
                    {
                        PlayerPrefs.SetInt(currentLVL + "lvl", 2);
                    }
                }
                if (Global_star.nxtStar <= 5)
                {
                    PlayerPrefs.SetInt(currentLVL + "lvl", 1);
                }
                
            }
        }
    }
    public void mew1()
    {
        FindObjectOfType<AudioManager>().Play("button");
        SceneManager.LoadScene(4);
        Global.nxtLevel = 2;
        if (Global.nxtLevel > PlayerPrefs.GetInt("curLVL"))
            PlayerPrefs.SetInt("curLVL", Global.nxtLevel);
    }
    public void mew2()
    {
        FindObjectOfType<AudioManager>().Play("button");
        SceneManager.LoadScene(4);
        Global.nxtLevel = 3;
        if (Global.nxtLevel > PlayerPrefs.GetInt("curLVL"))
            PlayerPrefs.SetInt("curLVL", Global.nxtLevel);
    }
    public void mew3()
    {
        FindObjectOfType<AudioManager>().Play("button");
        SceneManager.LoadScene(4);
        Global.nxtLevel = 0;
        if (Global.nxtLevel > PlayerPrefs.GetInt("curLVL"))
            PlayerPrefs.SetInt("curLVL", Global.nxtLevel);
    }
}
