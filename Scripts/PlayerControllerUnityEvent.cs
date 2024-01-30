using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
        // Subscribe to the onGameStart event
        EventManager.Instance.onGameStart.AddListener(OnGameStart);
    }

    private void OnGameStart()
    {
        Debug.Log("PlayerController: Game has started!");
        // Add your custom logic here
    }
}
