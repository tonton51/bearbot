using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramover : MonoBehaviour
{
    float mouseSensitivity = 5f;  // �}�E�X�̊��x
    public Transform playerBody;  // �v���C���[�̃g�����X�t�H�[��

    float xRotation = 0f;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;  // �J�[�\�������b�N
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // �}�E�X�̈ړ��ʂɉ����ăJ��������]������
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // �㉺�����̉�]�p�x�𐧌�����

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
