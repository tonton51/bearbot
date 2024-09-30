using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class kumacontroller : MonoBehaviour
{
    
    public Transform[] patrolPoints;
    private int currentPoint = 0;
    private Transform currentDestination;
    private NavMeshAgent agent;
    public float minDistance = 1f;
    public float range = 3f;
    public float destinationThreshold = 100f;
    [SerializeField] float speed = 2; // �G�̓����X�s�[�h
    float seconds;
    float scenesecond;

    [SerializeField] public GameObject target; // �ǉ�
    //stop�{�^���ǉ��p
    //public GameObject robostop;
    //bool stopco;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        firstDestination();
        //stop�{�^���ǉ��p
        //bool stopco = false;
        //robostop = GameObject.Find("robostop");

    }

    void Update()
    {
        float distanceToDestination = Vector3.Distance(transform.position, currentDestination.position);
        //Debug.Log(distanceToDestination);
        //stop�{�^���ǉ��p
        //stopco = robostop.GetComponent<stoptest>().isStop;
        //if (stopco)
        //{
        //    Debug.Log(stopco);
        //    // �G�̈ړ����x��0�ɐݒ肵�Ē�~����
        //    agent.velocity = Vector3.zero;

        //    seconds += Time.deltaTime;
        //    if (seconds >= 10)
        //    {
        //        seconds = 0;
        //        robostop.GetComponent<stoptest>().isStop = false;
        //        Debug.Log("�J�E���g��");
        //    }
        //}
        //else
        //{
        //    Debug.Log(stopco);
        if (distanceToDestination < destinationThreshold)
            {
                Debug.Log("���̖ړI�n��");
                GetNextDestination();
            //stop�{�^���ǉ��p
            //if (stopco)
            //{
            //    Debug.Log("�Ă���");
            //    return;
            //}
            }

            //�v���C���[�����͈͓̔��Ō��m������ǐՂ���
                if (Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) <= range)
                {
                     Debug.Log("move;");
                    //if (stopco) { return; }
                    move();
                    if(Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) > range)
                    {
                        Debug.Log("�͈͊O��");

                        Debug.Log("�ړI�n��");
                        //if (stopco) { return; }
                        if (Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) <= range) return;
                        agent.SetDestination(currentDestination.position);
                        return;
                    }
                }
                //stop�{�^���ǉ��p
                //else
                //{
                //    Debug.Log("�͈͊O��");

                //    Debug.Log("�ړI�n��");
                //    //if (stopco) { return; }
                //    if (Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) <= range) return;
                //    agent.SetDestination(currentDestination.position);
                //    return;
                //}
    }






void GetNextDestination()
    {
        Debug.Log(patrolPoints.Length);
        if (patrolPoints.Length == 0) return;
        //if (stopco) { return; }
        if (Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) <= range) return;
        //currentDestination = patrolPoints[currentPoint];
        int count = 0;
        int randomIndex = Random.Range(0, patrolPoints.Length); //�����_���ɐݒ�e�X�g
        currentDestination = patrolPoints[randomIndex]; //�@// �����_���ɐݒ�e�X�g
        agent.SetDestination(currentDestination.position);
        //currentPoint = (currentPoint + 1) % patrolPoints.Length;
        Debug.Log("����");
        Debug.Log("Next destination: " + currentDestination.position);
    }

    void firstDestination()
    {

        //if (patrolPoints.Length == 0) return;
        //currentDestination = patrolPoints[currentPoint];
        int randomIndex = Random.Range(0, patrolPoints.Length); //�����_���ɐݒ�e�X�g
        currentDestination = patrolPoints[randomIndex]; // �����_���ɐݒ�e�X�g
        agent.SetDestination(currentDestination.position);
        //currentPoint = (currentPoint + 1) % patrolPoints.Length;
        Debug.Log("first");
        Debug.Log("Next destination: " + currentDestination.position);
        return;

    }

    void move()
    {

        agent.destination = target.transform.position;
        Debug.Log("�v���C���[��ǐՒ�");
        //if (stopco) { return; Debug.Log("��"); }
        if (Vector3.Distance(transform.position, GameManager.Instance.player.transform.position) > range)
        {
            Debug.Log("�͈͊O��");
            currentDestination = null;
            return;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // player�������ꍇ
        if (collision.gameObject.tag == "player")
        {
            scenesecond += Time.deltaTime;
            if (scenesecond >= 0.1)
            {
                Debug.Log("�Q�[���I�[�o�[");
                SceneManager.LoadScene("GameOver");
            }
            

        }
    }
}


