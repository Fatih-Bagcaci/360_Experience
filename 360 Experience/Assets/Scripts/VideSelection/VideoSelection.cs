using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VideoSelection
{
    private static string selectedVideo;
    private static string videoClipPath;

    // List of all video identifiers.
    public enum Video {
        Beach,
        Waterfall,
        }


    public static string SelectedVideo
    {
        get
        {
            return selectedVideo;
        }
        set
        {
            selectedVideo = value;
        }
    }

    // Set file path from '/Resources/' onward to the selected video.
    public static string SetVideoClip(){
        if(selectedVideo == Video.Beach.ToString()){
            videoClipPath = "360 Videos/360_Beach";
        }
        else if(selectedVideo == Video.Waterfall.ToString()){
            videoClipPath = "360 Videos/360_Waterfall";
        }
        else{
            Debug.Log("Selected video doesn't exist!");
        }

        return videoClipPath;
    }
}
