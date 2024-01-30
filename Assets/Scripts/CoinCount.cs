using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int coinCount = 0;
    public TMPro.TextMeshProUGUI coinCountText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++; // Increase the counter when the player collides with a coin
            UpdateCoinCountUI(); // Update the coin count display
            Destroy(other.gameObject); // Destroy the coin
        }
    }

    void UpdateCoinCountUI()
    {
        coinCountText.text = "Coins: " + coinCount.ToString(); // Update the UI display text
    }
}

