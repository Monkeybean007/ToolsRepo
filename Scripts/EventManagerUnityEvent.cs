using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    // Define your custom event
    public UnityEvent onGameStart;

    // Method to trigger the event
    public void StartGame()
    {
        onGameStart.Invoke();
    }
}
