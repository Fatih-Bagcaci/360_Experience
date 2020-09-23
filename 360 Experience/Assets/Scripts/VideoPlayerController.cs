using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{

    // Play the video selected in the main menu.
    void Start()
    {
        var videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        VideoClip videoClip = Resources.Load<VideoClip>(VideoSelection.SetVideoClip()) as VideoClip;
        videoPlayer.clip = videoClip;
        videoPlayer.Play();
    }
}
