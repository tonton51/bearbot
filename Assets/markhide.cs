using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class markhide : MonoBehaviour
{
    private void Start()
    {
        // "PatrolPoint" タグのついたオブジェクトをすべて取得する
        GameObject[] patrolPoints = GameObject.FindGameObjectsWithTag("mark");

        // 取得したオブジェクトを非表示にする
        foreach (GameObject patrolPoint in patrolPoints)
        {
            patrolPoint.SetActive(false);
        }
    }
}
