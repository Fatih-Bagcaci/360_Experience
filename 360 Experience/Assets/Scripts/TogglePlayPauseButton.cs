using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePlayPauseButton : MonoBehaviour
{
    private Button button;
    private Image image;
    private bool isPaused;
    private Sprite playImage, pauseImage;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleImage);

        image = GetComponent<Image>();

        isPaused = false;   // The video is playing at the beginning.
        
        // Load images for the play and pause button
        playImage = Resources.Load<Sprite>("Sprites/PlayButton") as Sprite;
        pauseImage = Resources.Load<Sprite>("Sprites/PauseButton") as Sprite;
    }

    // Toggle the image of the play and pause button when clicked
    // to indicate what action it will take: play or pause.
    private void ToggleImage(){
        // The video is paused.
        if(!isPaused){
            image.sprite = playImage;
            isPaused = true;
            return;
        }

        // The video is resuming.
        if(isPaused){
            image.sprite = pauseImage;
            isPaused = false;
            return;
        }
    }
}
