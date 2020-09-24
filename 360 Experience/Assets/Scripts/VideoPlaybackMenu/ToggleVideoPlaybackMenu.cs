using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToggleVideoPlaybackMenu : MonoBehaviour
{
    private Touch tap;
    private bool menuIsActive;
    [SerializeField] private GameObject toggleObject;

    // Start is called before the first frame update
    void Start()
    {
        menuIsActive = false;       // Menu is hidden at start.
    }

    // Update is called once per frame
    void Update()
    {
        RegisterTap();
    }

    // Check if user tapped the screen.
    private void RegisterTap(){
        // The uset tapped the screen.
        if(Input.touchCount > 0){
            tap = Input.GetTouch(0);

            //The user lifted finger from screen.
            if(tap.phase == TouchPhase.Ended &&
                !EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)){
                    ToggleGameObjectState();
            }
        }
    }

    // Show or hide the menu.
    private void ToggleGameObjectState(){
        // Show menu.
        if(!menuIsActive){
            toggleObject.SetActive(true);
            menuIsActive = true;
            return;
        }

        // Hide menu.
        if(menuIsActive){
            toggleObject.SetActive(false);
            menuIsActive = false;
            return;
        }
    }
}
