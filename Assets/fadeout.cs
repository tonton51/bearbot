using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeout : MonoBehaviour
{
    public GameObject Panelfade;   //フェードパネルの取得

    Image fadealpha;               //フェードパネルのイメージ取得変数

    private float alpha;           //パネルのalpha値取得変数

    private bool fade;          //フェードアウトのフラグ変数

    public int SceneNo;            //シーンの移動先ナンバー取得変数
    public areatest areatest;
    public bool areafade = false;


    // Use this for initialization
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>(); //パネルのイメージ取得
        alpha = fadealpha.color.a;                 //パネルのalpha値を取得
        fade = true;                             //シーン読み込み時にフェードインさせる
    }

    // Update is called once per frame
    void Update()
    {
        areafade = areatest.areafade;

        if (fade == true&&areafade==true)
        {
            FadeOut();
            
        }
    }

    void FadeOut()
    {
        alpha += 0.05f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha >= 1)
        {
            fade = false;
            SceneManager.LoadScene("bearmovie");
        }
        
    }

}
