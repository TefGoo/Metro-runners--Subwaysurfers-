using UnityEngine;
using UnityEngine.UI;

public class DelayedCanvasShow : MonoBehaviour
{
    public float delayTime = 2f; // The delay time in seconds
    private Canvas canvas; // Reference to the Canvas component

    void Start()
    {
        canvas = GetComponent<Canvas>(); // Get the Canvas component
        canvas.enabled = false; // Hide the Canvas by default

        // Call the ShowCanvas() method after the delay time
        Invoke("ShowCanvas", delayTime);
    }

    void ShowCanvas()
    {
        canvas.enabled = true; // Show the Canvas
    }
}
