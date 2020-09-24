using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private VideoClip videoClip;
    private bool isPaused;

    public bool IsPaused
    {
        get
        {
            return isPaused;
        }
    }

    void Start()
    {
        InitiateVideo();
    }

    // Play the video selected in the main menu.
    private void InitiateVideo(){
        videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoClip = Resources.Load<VideoClip>(VideoSelection.SetVideoClip()) as VideoClip;
        videoPlayer.clip = videoClip;
        videoPlayer.Play();
        isPaused = false;
    }

    // Toggle between playing and pausing the video.
    public void ToggleVideoStatus(){
        // The video is paused.
        if(!isPaused){
            videoPlayer.Pause();
            isPaused = true;
            return;
        }

        // The video is resuming.
        if(isPaused){
            videoPlayer.Play();
            isPaused = false;
            return;
        }
    }
}
