using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class areatest : MonoBehaviour
{
    public bool areafade = false; //�G���A�ɂ��邩�ۂ��̔���




    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            // �v���C���[��Empty�̃R���C�_�[�ɓ������Ƃ�
            Debug.Log("����");
            areafade = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
           
            Debug.Log("�o��");
            // �v���C���[��Empty�̃R���C�_�[����o���Ƃ�
            areafade = false;
        }
    }


}
