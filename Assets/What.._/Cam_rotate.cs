using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_rotate : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    public float xSens = 100f;
    public float ySens = 100f;
    Quaternion center;
    public static bool cursorLock = true;
    void Start()
    {
        center = cam.localRotation;
    }
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * ySens * Time.deltaTime;
        Quaternion yRot = cam.localRotation * Quaternion.AngleAxis(mouseY, -Vector3.right);
        if (Quaternion.Angle(center, yRot) < 90f)
            cam.localRotation = yRot;
        float mouseX = Input.GetAxis("Mouse X") * xSens * Time.deltaTime;
        Quaternion xRot = player.localRotation * Quaternion.AngleAxis(mouseX, Vector3.up);
        player.localRotation = xRot;
        if (cursorLock)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (Input.GetKeyDown(KeyCode.Escape))
                cursorLock = true;
        }
    }
}
