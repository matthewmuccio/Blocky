﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;

// MainMenu controls the Main Menu scene, including the version text, high score text, the three main buttons, the credit text, and
// managing the scene movement.
public class MainMenu : MonoBehaviour
{
    // Refers to the Text object that displays the player's current high score.
    public Text highScoreText;

    // Use this for initialization.
    void Start()
    {
        // Set the high score text to the player's current high score using PlayerPrefs.
        highScoreText.text = "High Score: " + ((int)PlayerPrefs.GetFloat("highScore"));
    }

    // Runs when the player clicks the "Play" button.
    public void Play()
    {
        // Starts a new Coroutine that begins loading the Game scene.
        StartCoroutine(loading());
    }

    // Returns an IEnumerator that begins loading the Game scene, waits a second, and changes the scene to begin gameplay.
    IEnumerator loading()
    {
        // Creates a yield instruction to wait for one second using scaled time.
        yield return new WaitForSeconds(1F);
        // SceneManager controls scene management at runtime.
        // LoadScene loads the Loading scene after waiting a second and then loads the main gameplay.
        SceneManager.LoadScene("Loading");
    }

    // Runs when the player clicks the "About" button.
    // Currently opens a browser and sends the player to my website, but eventually
    // will load a scene with information about the game and the team.
    public void About()
    {
        // Opens the URL parameter in a browser.
        Application.OpenURL("http://www.matthewmuccio.com");
    }

    // Runs when the player clicks the "Exit" button.
    // Eventually will be changed.
    public void Exit()
    {
        // Quits the current Application.
        Application.Quit();
    }
}