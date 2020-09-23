using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController
{
    // List of all scene names.
    public enum Scene{ 
        MainMenu,
        VideoPlayback,
    }

    // Set scene to requested scene.
    public static void GoToScene(Scene scene){
        SceneManager.LoadScene(scene.ToString());
    }
}
