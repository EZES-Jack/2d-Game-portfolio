using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deaths : MonoBehaviour
{
    // Static variable to keep track of the number of deaths
    public static int deaths;                              
    // UI Text component to display the number of deaths
    public Text deathsText;                             
    // Vector to store the respawn point position
    private Vector3 respawnPoint;                 
    // GameObject to detect falls
    public GameObject FallDetector;               
    // Rigidbody2D component of the player
    private Rigidbody2D player;                          

    void Start()
    {
        // Set the respawn point to the initial position of the player
        respawnPoint = transform.position;                  
        // Initialize the deathsText with the current number of deaths
        deathsText.text = "Deaths: " + Deaths.deaths;     
        // Get the Rigidbody2D component attached to the player
        player = GetComponent<Rigidbody2D>();              
    }

    // Method called when the collider enters a trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "waterfall"
        if (collision.gameObject.tag == "waterfall")
        {
            // Reset the player's position to the respawn point
            transform.position = respawnPoint;
            // Increment the deaths count
            Deaths.deaths += 1;
            // Update the deathsText with the new number of deaths
            deathsText.text = "Deaths: " + Deaths.deaths;
        }
        // Check if the collided object has the tag "FallDetector"
        if (collision.gameObject.tag == "FallDetector")
        {
            // Reset the player's position to the respawn point
            transform.position = respawnPoint;
            // Increment the deaths count
            Deaths.deaths += 1;
            // Update the deathsText with the new number of deaths
            deathsText.text = "Deaths: " + Deaths.deaths;
        }
    }
}
