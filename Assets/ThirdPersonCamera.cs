using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;

    public float distance = 5f;
    public float sensitivity = 2f;
    public float heightOffset = 1.5f;


    public float rotX = 0f;
    public float rotY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotY += mouseX;
        rotX -= mouseY;

        rotX = Mathf.Clamp(rotX, -90, 90);
        transform.localRotation = Quaternion.Euler(rotX, rotY, 0f);

    }

    private void LateUpdate()
    {
        Vector3 targetOffset = target.position - target.forward * distance + Vector3.up * heightOffset;

        transform.position = targetOffset;

        transform.LookAt(target);
    }
}
