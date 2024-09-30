using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class movietest : MonoBehaviour
{
    [SerializeField]
    VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.loopPointReached += LoopPointReached;
        videoPlayer.Play();
    }

    public void LoopPointReached(VideoPlayer vp)
    {
        // “®‰æÄ¶Š®—¹‚Ìˆ—
        SceneManager.LoadScene("Escape");
    }
}
