using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Transform playerTransform;
    private SwipeControls swipeControls;

    private enum Lane
    {
        Lane1,
        Lane2,
        Lane3
    }

    private Lane currentLane = Lane.Lane2;

    private void Start()
    {
        playerTransform = GetComponent<Transform>();
        swipeControls = GetComponent<SwipeControls>();
    }

    private void Update()
    {
        MovePlayer();
        ChangeLane();
    }

    private void MovePlayer()
    {
        float targetZ = 0;

        switch (currentLane)
        {
            case Lane.Lane1:
                targetZ = -1.1f;
                break;
            case Lane.Lane2:
                targetZ = 0;
                break;
            case Lane.Lane3:
                targetZ = 1.1f;
                break;
        }

        float speed = 10.5f * Time.deltaTime;
        playerTransform.position = Vector3.MoveTowards(playerTransform.position, new Vector3(playerTransform.position.x, playerTransform.position.y, targetZ), speed);
    }

    private void ChangeLane()
    {
        if (swipeControls.swipeleft && currentLane != Lane.Lane1)
        {
            currentLane--;
        }
        else if (swipeControls.swiperight && currentLane != Lane.Lane3)
        {
            currentLane++;
        }
    }
}
