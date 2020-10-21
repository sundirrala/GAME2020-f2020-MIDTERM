using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this is for the scrolling background. it resets when the second background reaches the boundary.
/// Date Modified: 2020-10-21
/// </summary>

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(verticalBoundary, 0.0f); // you'll need to flip this, since we're more concerned about the x bound than the y.
    }

    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
