using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sped_up_scr : Move_sph
{
    //public float speed;
    //void Start()
    //{
    //    Move_sph move = new Move_sph();
    //    speed = move.speed;
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            speed = speed * 2;
        }
    }
}
