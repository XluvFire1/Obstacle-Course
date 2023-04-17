using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //define some constants
    private const float LOW_LIMIT = 0.0f;
    private const float HIGH_LIMIT = 85.0f;

    //these will be available in the editor
    public GameObject theCamera;
    public float followDistance = 5.0f;
    public float mouseSensitivityX = 4.0f;
    public float mouseSensitivityY = 2.0f;
    public float heightOffset = 0.5f;


    // Use this for initialization
    void Start()
    {
        //place the camera and set the forward vector to match player
        theCamera.transform.forward = gameObject.transform.forward;
        //hide the cursor and lock the cursor to center
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            //if we are not paused, get the mouse movement and adjust the camera
            //position and rotation to reflect this movement around player
            Vector2 cameraMovement = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

            //first we place the camera at the position of the player + height offset
            theCamera.transform.position = gameObject.transform.position + new Vector3(0, heightOffset, 0);

            //next we adjust the rotation based on the captured mouse movement
            //we clamp the pitch (X angle) of the camera to avoid flipping
            //we also adjust the values to account for mouse sensitivity settings
            theCamera.transform.eulerAngles = new Vector3(
                Mathf.Clamp(theCamera.transform.eulerAngles.x + cameraMovement.y * mouseSensitivityY, LOW_LIMIT, HIGH_LIMIT),
                theCamera.transform.eulerAngles.y + cameraMovement.x * mouseSensitivityX, 0);

            //then we move out to the desired follow distance
            theCamera.transform.position -= theCamera.transform.forward * followDistance;
        }
    }
}