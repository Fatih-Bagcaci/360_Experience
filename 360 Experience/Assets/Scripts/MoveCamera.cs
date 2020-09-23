using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private bool gyroExists;
    private Gyroscope gyro;
    private Quaternion rotation;

    void Start()
    {
        gyroExists = CheckGyro();

    }

    void Update()
    {
        // Rotate camera with phone.
        if(gyroExists){
            transform.localRotation = gyro.attitude * rotation;
        }
    }

    // Check if phone has a built in gyroscope.
    private bool CheckGyro(){
        // The phone has a built in gyroscope.
        if(SystemInfo.supportsGyroscope){
            // Set the gyroscope to the phone's built in gyroscope and enable it.
            gyro = Input.gyro;
            gyro.enabled = true;

            // Setup for camera movement with phone.
            transform.parent.rotation = Quaternion.Euler(90f, 280f, 0f);    // Allign 360 video orientation to real world orientation. 
            rotation = new Quaternion(0, 0, 1, 0);                          // Revert inverted camera rotation.

            return true;
        }

        // The phone has no built in gyroscope.
        return false;
    }
}
