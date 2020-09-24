using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSelecter : MonoBehaviour
{
    // Select the first video Beach.
    public void SelectVideo1(){
        VideoSelection.SelectedVideo = VideoSelection.Video.Beach.ToString();
        SceneController.GoToScene(SceneController.Scene.VideoPlayback);

    }

    // Select the second video Waterfall.
    public void SelectVideo2(){
        VideoSelection.SelectedVideo = VideoSelection.Video.Waterfall.ToString();
        SceneController.GoToScene(SceneController.Scene.VideoPlayback);
    }

}
