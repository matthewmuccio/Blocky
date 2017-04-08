﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // The speed of the Player.
    public Vector2 speed = new Vector2(10, 10);

    // Store the movement of the Player and the component.
    private Vector2 movement;
    private Rigidbody2D rigidBodyComponent;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Obtain the axis information.
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Movement per direction.
        movement = new Vector2(speed.x * inputX,
                                speed.y * inputY);
    }

    // FixedUpdate is called at every fixed framerate frame.
    // Use this method over Update when dealing with physics.
    void FixedUpdate()
    {
        // Get the component and store the reference.
        if (rigidBodyComponent == null)
            rigidBodyComponent = GetComponent<Rigidbody2D>();

        // Move the game object (Player).
        rigidBodyComponent.velocity = movement;
    }
}