using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class texttest : MonoBehaviour
{
    public string[] sentences; // ���͂��i�[����
    [SerializeField] Text uiText;   // uiText�ւ̎Q��

    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharDisplay = 0.05f;   // 1�����̕\���ɂ����鎞��

    private int currentSentenceNum = 0; //���ݕ\�����Ă��镶�͔ԍ�
    private string currentSentence = string.Empty;  // ���݂̕�����
    private float timeUntilDisplay = 0;     // �\���ɂ����鎞��
    private float timeBeganDisplay = 1;         // ������̕\�����J�n��������
    private int lastUpdateCharCount = -1;       // �\�����̕�����
    protected string currentScene;  // ���݂̃V�[��
    public bool textend = false;


    void Start()
    {
        SetNextSentence();
    }


    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;
        // ���͂̕\������ / ������
        if (IsDisplayComplete())
        {
            //�Ō�̕��͂ł͂Ȃ� & �{�^���������ꂽ
            if (currentSentenceNum < sentences.Length && Input.GetMouseButtonDown(0))
            {
                SetNextSentence();
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (currentScene == "startstory")
                    {
                        Debug.Log("���̃V�[��");
                        SceneManager.LoadScene("story2nd");
                    }
                    //if (currentScene == "story3rd")
                    //{
                        uiText.enabled = false;
                        textend = true;
                    //}
                    
                }
            }
        }
        else
        {
            //�{�^���������ꂽ
            if (Input.GetMouseButtonDown(0))
            {
                if (currentScene == "startstory")
                {
                    Debug.Log("���̃V�[��");
                    SceneManager.LoadScene("story2nd");
                }
                timeUntilDisplay = 0; //��1
            }
        }

        //�\������镶�������v�Z
        int displayCharCount = (int)(Mathf.Clamp01((Time.time - timeBeganDisplay) / timeUntilDisplay) * currentSentence.Length);
        //�\������镶�������\�����Ă��镶�����ƈႤ
        if (displayCharCount != lastUpdateCharCount)
        {
            uiText.text = currentSentence.Substring(0, displayCharCount);
            //�\�����Ă��镶�����̍X�V
            lastUpdateCharCount = displayCharCount;
        }
    }

    // ���̕��͂��Z�b�g����
    void SetNextSentence()
    {
        currentSentence = sentences[currentSentenceNum];
        timeUntilDisplay = currentSentence.Length * intervalForCharDisplay;
        timeBeganDisplay = Time.time;
        currentSentenceNum++;
        lastUpdateCharCount = 0;
    }

    bool IsDisplayComplete()
    {
        return Time.time > timeBeganDisplay + timeUntilDisplay; //��2
    }
}
