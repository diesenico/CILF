using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningThing : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public Transform respawnPoint; // The point at which the object respawns

    void Update()
    {
        
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); // Rotate the object
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Respawn();
        }
    }

    void Respawn() //Set the object's position to the respawn point
    {
        
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;
    }
}
