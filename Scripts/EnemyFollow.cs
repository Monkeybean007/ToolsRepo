using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 3.0f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Continuously follow the player if the reference is valid
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            // Flip the sprite based on the player's relative position
            FlipSprite(direction.x);

            // Move towards the player
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    // Flip the sprite based on the direction
    private void FlipSprite(float directionX)
    {
        if (directionX > 0 && transform.localScale.x > 0)
        {
            // Face right and the sprite is not already flipped
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (directionX < 0 && transform.localScale.x < 0)
        {
            // Face left and the sprite is not already flipped
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
