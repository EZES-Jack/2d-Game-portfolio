using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    // Static variable to keep track of the total score
    public static int totalScore;                         
    // UI Text component to display the score
    public Text scoreText;                                   

    void Start()
    {
        // Initialize the scoreText with the current total score
        scoreText.text = "Score: " + Scoring.totalScore;      
    }

    // Method called when the collider enters a trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "P_PotionBlue2"
        if (collision.tag == "P_PotionBlue2")                  
        {                                                      
            // Increment the total score by 1
            Scoring.totalScore += 1;                          
            // Update the scoreText with the new total score
            scoreText.text = "Score: " + Scoring.totalScore;   
        }
        // Check if the collided object has the tag "level3"
        else if (collision.tag == "level3")                 
        {
            // Increment the total score by 1
            Scoring.totalScore += 1;                          
            // Update the scoreText with the new total score
            scoreText.text = "Score: " + Scoring.totalScore;   
        }
        // Check if the collided object has the tag "end game +3"
        else if (collision.tag == "end game +3")             
        {
            // Increment the total score by 3
            Scoring.totalScore += 3;                         
            // Update the scoreText with the new total score
            scoreText.text = "Score: " + Scoring.totalScore;  
        }
        // Check if the collided object has the tag "end game+10"
        else if (collision.tag == "end game+10")              
        {
            // Increment the total score by 10
            Scoring.totalScore += 10;                         
            // Update the scoreText with the new total score
            scoreText.text = "Score: " + Scoring.totalScore; 
        }
    }
}
