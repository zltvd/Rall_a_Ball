using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Score : Move_sph
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetText()
    {
        Score.text = "Score: " + count.ToString();
    }
}
