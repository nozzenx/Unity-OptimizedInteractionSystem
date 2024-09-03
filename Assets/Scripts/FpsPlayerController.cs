using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class FpsPlayerController : MonoBehaviour
{
[Header("Movement Speeds")]
    [SerializeField] float walkSpeed = 3.0f; 

[Header("Look Options")]
    [SerializeField] float lookSensivity = 2.0f;
    [SerializeField] float upDownRange = 80.0f;


    private float verticalSpeed;
    
    private CharacterController charController;
    private Camera cam;
    private float height;


    private void Start()
    {
        Cursor.visible = false;
        charController = GetComponent<CharacterController>();        
        cam = Camera.main;
        height = charController.height;
    }

    private void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleCrouch();
    }

    private void HandleMovement()
    {
        float verticalSpeed = Input.GetAxis("Vertical") * walkSpeed;
        float horizontalSpeed = Input.GetAxis("Horizontal") * walkSpeed;

        Vector3 speed = new Vector3(horizontalSpeed, 0, verticalSpeed);
        speed = transform.rotation * speed;
        charController.SimpleMove(speed);
    }

    private void HandleRotation()
    {
        float mouseXRotation = Input.GetAxis("Mouse X") * lookSensivity;
        transform.Rotate(0, mouseXRotation, 0);
        
        verticalSpeed -= Input.GetAxis("Mouse Y") * lookSensivity;
        verticalSpeed = Mathf.Clamp(verticalSpeed, -upDownRange, upDownRange);

        cam.transform.localRotation = Quaternion.Euler(verticalSpeed, 0, 0);
    }

    private void HandleCrouch()
    {
        
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.C))
        {
            charController.height /= 2;
        }
        else
        {
            charController.height = height;
        }
    }
}
