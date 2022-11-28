using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

/*
 * This script is used to control the camera movement. It moves the object that the camera is following.
 */
public class CameraMovement : MonoBehaviour
{
    //Objects
    [SerializeField] private Transform cameraRoot;
    //[SerializeField] private CharacterController characterBody;

    //camera settings
    [SerializeField][Range(-2, 2)] private float camSliderHorizontal, camSliderVertical;

    //Input settings
    //[SerializeField] private float cursorSpeedHorizontal = 4f;
    [SerializeField] private float cursorSpeedVertical = 4f;


    private float verticalAngle = 0;
    //private float horizontalAngle = 0;
    void Start()
    {
        cameraRoot = GetComponent<Transform>();
        //characterBody = FindObjectOfType <CharacterController>();
    }

    private void Update()
    {
        //Get cursor input
        float verticalInput = -Input.GetAxis("Mouse Y") * cursorSpeedVertical;
        //float horizontalInput = Input.GetAxis("Mouse X") * cursorSpeedHorizontal;
        verticalAngle = Mathf.Clamp(verticalAngle + verticalInput, -30, 60);
        //horizontalAngle = (horizontalAngle + horizontalInput) % 360;

        //Rotate the camera according to cursor input
        cameraRoot.transform.localRotation = Quaternion.Euler(verticalAngle,
            0f, 0f);
    }
}