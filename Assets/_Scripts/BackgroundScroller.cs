using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float startingSpeed = 10f;
    public float speedIncreasePerSecond = 0.5f;
    private float currentSpeed;
    private Vector3 movementVector;

    private void Start()
    {
        currentSpeed = startingSpeed;
        movementVector = new Vector3(-currentSpeed, 0f, 0f);
    }

    private void Update()
    {
        currentSpeed += speedIncreasePerSecond * Time.deltaTime;
        movementVector.x = -currentSpeed;
        transform.Translate(movementVector * Time.deltaTime);
    }
}
