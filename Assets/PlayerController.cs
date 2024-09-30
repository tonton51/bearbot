using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // rigidbodyの定義
    Rigidbody m_Rigidbody;
    float speed = 1.0f;
    
    Animation anim;
    //追加
    protected string currentScene;  // 現在のシーン
    bool textend=false;
    public texttest texttest;

    void Start()
    {
        // 自分のRigidbodyを取ってくる
        m_Rigidbody = GetComponent<Rigidbody>();
        
        anim = this.gameObject.GetComponent<Animation>();


    }

    void Update()
    {
        //会話用
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
                    // Spaceキーが押されていない場合の処理
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
            //Debug.Log("歩いた");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
            
            anim.Play("walk_00");
            //Debug.Log("歩いた");
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
            
            anim.Play("walk_00");
            //Debug.Log("歩いた");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * -1 * speed;
            
            anim.Play("walk_00");
            //Debug.Log("歩いた");
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
            //Debug.Log("走った");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
            
            anim.Play("run_00");
            //Debug.Log("走った");
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
            
            anim.Play("run_00");
            //Debug.Log("走った");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * -1 * speed;
            
            anim.Play("run_00");
            //Debug.Log("走った");
        }
        else
        {
            anim.Stop();
            
        }
    }
}
