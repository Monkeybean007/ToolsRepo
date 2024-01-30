using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void Start()
    {
        // Subscribe to the onGameStart event
        EventManager.Instance.onGameStart.AddListener(OnGameStart);
    }

    private void OnGameStart()
    {
        Debug.Log("UIManager: Game has started!");
        // Add your UI-related logic here
    }
}
