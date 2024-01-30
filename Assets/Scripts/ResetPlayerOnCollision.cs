using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerOnCollision : MonoBehaviour
{
    public Transform startPoint; // The starting point to which the player should return

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Check if the player collided
        {
            collision.gameObject.transform.position = startPoint.position; // Move players to the starting point
        }
    }
}
