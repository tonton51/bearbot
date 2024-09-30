using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighttest : MonoBehaviour
{
    public float mouseXSensitivity = 5f;

    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; // カーソルロック
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseXSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseXSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
