using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Move_sph1 : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody rb;
    private int count;
    public TMP_Text Score;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetText();
        }
        if (other.gameObject.CompareTag("SpeedUp"))
        {
            other.gameObject.SetActive(false);
            speed = speed + 2;
        }
        if (other.gameObject.CompareTag("SpeedFloor"))
        {
            speed = speed + 6;
        }
    }
    private void SetText()
    {
        Score.text = "Score: " + count.ToString();
    }

}
