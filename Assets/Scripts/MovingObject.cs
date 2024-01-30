using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the object moves

    public Transform startPoint; // Reference to the GameObject for the starting point
    public Transform endPoint; // Reference to the GameObject for the endpoint
    public Transform respawnPoint; // Reference to the GameObject for the respawn point

    private Vector3 startPos; // The starting position of the object
    private Vector3 endPos; // The end position of the object
    private bool movingToEnd = true; // Indicates whether the object is currently moving to the end point

    void Start()
    {
        startPos = startPoint.position; // Set the starting position
        endPos = endPoint.position; // Set the end position
    }

    void Update()
    {
        // Set direction based on movingToEnd
        Vector3 targetPos = movingToEnd ? endPos : startPos;
        // Move the object towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        // Check whether the object has reached the target position
        if (Vector3.Distance(transform.position, targetPos) < 0.01f)
        {
            movingToEnd = !movingToEnd; // Reverse the direction of movement
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Check if the player collided
        {
            RespawnPlayer(collision.gameObject); // Respawn player
        }
    }

    void RespawnPlayer(GameObject player)
    {
        if (respawnPoint != null)
        {
            player.transform.position = respawnPoint.position; // Teleport players to the spawn location
        }
        else
        {
            Debug.LogError("Respawn point not set!"); // Show error message if respawn point is not set
        }
    }
}
