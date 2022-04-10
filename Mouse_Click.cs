using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Click : MonoBehaviour
{

    [SerializeField] private float sensitivity;
    [SerializeField] private Transform body;

    private float xRotation = 0f;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){

        float mouse_x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouse_y;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation,0,0);

        body.Rotate(Vector3.up * mouse_x);
    }
}
