using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        // Camera rotation to the left with the J key
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.left, -rotationSpeed * Time.deltaTime);
        }

        // Camera rotation to the right with the L key
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
        }

        // Camera rotation up with the I button
        if (Input.GetKey(KeyCode.I))
        {
            transform.Rotate(Vector3.right, -rotationSpeed * Time.deltaTime);
        }

        // Camera rotation down with the K key
        if (Input.GetKey(KeyCode.K))
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
    }
}
