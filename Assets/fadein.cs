using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadein : MonoBehaviour
{
    public GameObject Panelfade;   //�t�F�[�h�p�l���̎擾

    Image fadealpha;               //�t�F�[�h�p�l���̃C���[�W�擾�ϐ�

    private float alpha;           //�p�l����alpha�l�擾�ϐ�

    private bool fadeinp;          //�t�F�[�h�A�E�g�̃t���O�ϐ�

    public int SceneNo;            //�V�[���̈ړ���i���o�[�擾�ϐ�


    // Use this for initialization
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //�p�l���̃C���[�W�擾
        alpha = fadealpha.color.a;                 //�p�l����alpha�l���擾
        fadeinp = true;                             //�V�[���ǂݍ��ݎ��Ƀt�F�[�h�C��������
    }

    // Update is called once per frame
    void Update()
    {

        if (fadeinp == true)
        {
            FadeIn();
        }
    }

    void FadeIn()
    {
        alpha -= 0.1f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha <= 0)
        {
            fadeinp = false;
        }
    }

}
