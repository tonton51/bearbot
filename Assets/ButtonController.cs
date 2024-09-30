using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("startstory");
    }
    public void Walking()
    {
        SceneManager.LoadScene("shopwalking");
    }
    public void Escape()
    {
        SceneManager.LoadScene("Escape");
    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
}
