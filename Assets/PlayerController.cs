using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // rigidbody�̒�`
    Rigidbody m_Rigidbody;
    float speed = 1.0f;
    
    Animation anim;
    //�ǉ�
    protected string currentScene;  // ���݂̃V�[��
    bool textend=false;
    public texttest texttest;

    void Start()
    {
        // ������Rigidbody������Ă���
        m_Rigidbody = GetComponent<Rigidbody>();
        
        anim = this.gameObject.GetComponent<Animation>();


    }

    void Update()
    {
        //��b�p
        textend = texttest.textend;
        currentScene = SceneManager.GetActiveScene().name;
       
            if (textend)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    run();

                }
                else if (!Input.GetKey(KeyCode.Space))
                {
                    // Space�L�[��������Ă��Ȃ��ꍇ�̏���
                    walk();
                }
            }
            
        

    }

    private void walk()
    {
        speed = 1.0f;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * Time.deltaTime * -1 * speed;
            
            anim.Play("walk_00");
            //Debug.Log("������");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
            
            anim.Play("walk_00");
            //Debug.Log("������");
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
            
            anim.Play("walk_00");
            //Debug.Log("������");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * -1 * speed;
            
            anim.Play("walk_00");
            //Debug.Log("������");
        }
        else
        {
            anim.Stop();
            
        }
    }

    private void run()
    {
        speed = 3.0f;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * Time.deltaTime * -1 * speed;
            
            anim.Play("run_00");
            //Debug.Log("������");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
            
            anim.Play("run_00");
            //Debug.Log("������");
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
            
            anim.Play("run_00");
            //Debug.Log("������");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * -1 * speed;
            
            anim.Play("run_00");
            //Debug.Log("������");
        }
        else
        {
            anim.Stop();
            
        }
    }
}
