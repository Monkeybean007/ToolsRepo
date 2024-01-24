using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public Text winText; // Reference to a UI Text component for displaying the win message

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player enters the win zone
        if (other.CompareTag("Player"))
        {
            // Display the win message
            if (winText != null)
            {
                winText.text = "You Win!";
            }

            // Optionally, you can end the game by pausing or resetting the level
            // For example:
            // Time.timeScale = 0f; // Pause the game
            // Or
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart the level

            // You can also use other game-ending logic here
        }
    }
}
