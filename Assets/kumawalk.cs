using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class kumawalk : MonoBehaviour
{


    public Transform[] patrolPoints;
    private int currentPoint = 0;
    private Transform currentDestination;
    private NavMeshAgent agent;
    public float minDistance = 1f;
    public float range = 3f;
    public float destinationThreshold = 100f;
    [SerializeField] float speed = 2; // �G�̓����X�s�[�h

    



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        firstDestination();
    }

    void Update()
    {
        float distanceToDestination = Vector3.Distance(transform.position, currentDestination.position);
        
        if (distanceToDestination < destinationThreshold)
        {
            Debug.Log("���̖ړI�n��");
            GetNextDestination();
        }
    }






    void GetNextDestination()
    {
        Debug.Log(patrolPoints.Length);
        if (patrolPoints.Length == 0) return;

        if (Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) <= range) return;

        int count = 0;
        int randomIndex = Random.Range(0, patrolPoints.Length); //�����_���ɐݒ�e�X�g
        currentDestination = patrolPoints[randomIndex];//�@// �����_���ɐݒ�e�X�g
        agent.SetDestination(currentDestination.position);

        Debug.Log("����");
        Debug.Log("Next destination: " + currentDestination.position);
    }

    void firstDestination()
    {


        int randomIndex = Random.Range(0, patrolPoints.Length); //�����_���ɐݒ�e�X�g
        currentDestination = patrolPoints[randomIndex]; // �����_���ɐݒ�e�X�g
        agent.SetDestination(currentDestination.position);

        Debug.Log("first");
        Debug.Log("Next destination: " + currentDestination.position);
        return;

    }



    
}

