using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemtouchtest : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject key;
    // Start is called before the first frame update
    public bool keyget = false;
    void Start()
    {
        key.SetActive(true);
    }

    public void onClickAct()
    {
        key.SetActive(false);
        keyget = true;

    }
}
