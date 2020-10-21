﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Nisara Drahman, 101120917
/// the enemy controller deals with the automatical movement of the enemy
/// and the boundaries of how far it can move on the y-axis
/// Date Modified; 2020-10-21
/// </summary>

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, horizontalSpeed * direction * Time.deltaTime,  0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
