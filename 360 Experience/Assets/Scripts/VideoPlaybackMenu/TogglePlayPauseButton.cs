using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePlayPauseButton : MonoBehaviour
{
    private Button button;
    private Image image;
    public VideoPlayerController videoPlayer;
    private Sprite playImage, pauseImage;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleImage);

        image = GetComponent<Image>();

        LoadImages();
    }

    // Toggle the image of the play and pause button when clicked
    // to indicate what action it will take: play or pause.
    private void ToggleImage(){
        // The video is paused.
        if(!videoPlayer.IsPaused){
            image.sprite = playImage;
        }

        // The video is resuming.
        if(videoPlayer.IsPaused){
            image.sprite = pauseImage;
        }

        // Change video status.
        videoPlayer.ToggleVideoStatus();
    }

    // Load images for the play and pause button
    private void LoadImages(){
        playImage = Resources.Load<Sprite>("Sprites/PlayButton") as Sprite;
        pauseImage = Resources.Load<Sprite>("Sprites/PauseButton") as Sprite;
    }
}
