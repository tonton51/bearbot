using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class areatest : MonoBehaviour
{
    public bool areafade = false; //エリアにいるか否かの判定




    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            // プレイヤーがEmptyのコライダーに入ったとき
            Debug.Log("いる");
            areafade = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
           
            Debug.Log("出た");
            // プレイヤーがEmptyのコライダーから出たとき
            areafade = false;
        }
    }


}
