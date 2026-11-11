using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float mouseSensitivity = 1f;

    private float verticalRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;

        transform.Rotate(0, horizontalRotation, 0);


        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);

        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
}
