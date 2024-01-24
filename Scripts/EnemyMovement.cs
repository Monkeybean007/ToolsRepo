using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to set the movement speed.
    public Transform player; // Reference to the player's transform.

    void Update()
    {
        if (player != null)
        {
            // Calculate the direction from the enemy to the player.
            Vector3 directionToPlayer = player.position - transform.position;

            // Normalize the direction to have a magnitude of 1.
            directionToPlayer.Normalize();

            // Move the enemy towards the player.
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
        }
    }
}
