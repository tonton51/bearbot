using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class markhide : MonoBehaviour
{
    private void Start()
    {
        // "PatrolPoint" �^�O�̂����I�u�W�F�N�g�����ׂĎ擾����
        GameObject[] patrolPoints = GameObject.FindGameObjectsWithTag("mark");

        // �擾�����I�u�W�F�N�g���\���ɂ���
        foreach (GameObject patrolPoint in patrolPoints)
        {
            patrolPoint.SetActive(false);
        }
    }
}
