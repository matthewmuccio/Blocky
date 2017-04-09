﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simply moves the current game object.
public class Enemy : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float ballForce;
    // Designer variables
    // Speed of the current object.
    //public Vector2 speed = new Vector2(10, 10);

    // Moving direction of the current object.
    //public Vector2 direction = new Vector2(-1, 0);

    // Store the movement of the Player and the component.
    //private Vector2 movement;
    //private Rigidbody2D rigidBodyComponent;
    //private int randDirection = 1;

    // Use this for initialization
    void Start()
    {
        rigidBody2D.AddForce(new Vector2(ballForce, ballForce));
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        //movement = new Vector2(speed.x * direction.x, speed.y * direction.y);

        /*switch(randDirection)
        {
            case 1:
                transform.Translate(-Vector2.up * 1 * Time.deltaTime);
                break;
            case 2:
                transform.Translate(Vector2.up * 1 * Time.deltaTime);
                break;
            case 3:
                transform.Translate(Vector2.right * 1 * Time.deltaTime);
                break;
            case 4:
                transform.Translate(-Vector2.right * 1 * Time.deltaTime);
                break;
        }*/
    }

    // FixedUpdate is called at every fixed framerate frame.
    // Use this method over Update when dealing with physics.
    void FixedUpdate()
    {
        // Get the component and store the reference.
        //if (rigidBodyComponent == null)
        //    rigidBodyComponent = GetComponent<Rigidbody2D>();

        // Move the game object (Player).
        //rigidBodyComponent.velocity = movement;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.name == "UpWall"
         || collision.gameObject.name == "DownWall"
         || collision.gameObject.name == "LeftWall"
         || collision.gameObject.name == "RightWall")
            randDirection = Random.Range(1, 5);*/
    }
}