using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToMainMenu : MonoBehaviour
{
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(GoToMainMenu);
    }

    private void GoToMainMenu(){
        SceneController.GoToScene(SceneController.Scene.MainMenu);
    }
}
