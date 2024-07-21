using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Move_sph : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody rb;
    public int count;
    public int nextLVL = 0;
    public TMP_Text Score;
    public GameObject loadScr;
    public Slider progressBar;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Global_star.nxtStar = 0;
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
            Global_star.nxtStar = Global_star.nxtStar + 1;
            SetText();
            FindObjectOfType<AudioManager>().Play("coin");
        }
        if (other.gameObject.CompareTag("SpeedUp"))
        {
            other.gameObject.SetActive(false);
            speed = speed + 2;
            FindObjectOfType<AudioManager>().Play("coin");
        }
        if (other.gameObject.CompareTag("SpeedFloor"))
        {
            speed = speed + 6;
        }
        if (other.gameObject.CompareTag("SpeedDown"))
        {
            other.gameObject.SetActive(false);
            speed = speed - 4;
            FindObjectOfType<AudioManager>().Play("coin");
        }
    }
    private void SetText()
    {
        Score.text = "Score: " + Global_star.nxtStar.ToString();
    }
}
