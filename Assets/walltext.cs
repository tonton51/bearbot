using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class walltext : MonoBehaviour
{    [SerializeField] Text uiText;   // uiTextへの参照
    float walltime = 0;

    void Start()
    {
        uiText.enabled = false;
    }

    void Update()
    {
        walltime += Time.deltaTime;
        Debug.Log(walltime);
        if (walltime >= 1)
        {
            uiText.enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        walltime = 0;
        // playerだった場合
        if (collision.gameObject.tag == "player")
        {
            uiText.enabled = true;
            

        }
        
        
    }


}
