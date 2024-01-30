using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private void Update()
    {
        // Example: Start the game when the player presses the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EventManager.Instance.StartGame();
        }
    }
}
