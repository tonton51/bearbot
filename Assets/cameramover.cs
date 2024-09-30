using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramover : MonoBehaviour
{
    float mouseSensitivity = 5f;  // マウスの感度
    public Transform playerBody;  // プレイヤーのトランスフォーム

    float xRotation = 0f;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;  // カーソルをロック
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // マウスの移動量に応じてカメラを回転させる
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // 上下方向の回転角度を制限する

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
