using UnityEngine;

public class ScaleSprite : MonoBehaviour
{
    public float scaleFactor = 1.5f; // The factor by which the sprite will be scaled
    public float duration = 1.0f; // The total duration of the scaling animation

    private Vector3 initialScale; // The initial scale of the sprite
    private float timer; // Timer to track the animation progress

    private void Start()
    {
        // Store the initial scale of the sprite
        initialScale = transform.localScale;
    }

    private void Update()
    {
        // Increment the timer based on the elapsed time since the last frame
        timer += Time.deltaTime;

        // Calculate the current scale based on the timer and desired duration
        float t = Mathf.PingPong(timer / duration, 1.0f);
        float scale = Mathf.Lerp(1.0f, scaleFactor, t);

        // Apply the new scale to the sprite
        transform.localScale = initialScale * scale;
    }
}
