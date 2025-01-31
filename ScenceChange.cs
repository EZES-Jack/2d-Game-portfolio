using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    // Method called when the collider enters a trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "P_PotionBlue"
        if (collision.gameObject.tag == "P_PotionBlue")
        {
            // Load scene1 asynchronously
            SceneManager.LoadSceneAsync("scene1", LoadSceneMode.Single);
            // Reset the scoring total score
            Scoring.totalScore = 0;
            // Reset the timer
            Timer.timer = 0;
        }
        // Check if the collided object has the tag "P_PotionBlue2"
        if (collision.gameObject.tag == "P_PotionBlue2")
        {
            // Load scene2 asynchronously
            SceneManager.LoadSceneAsync("scene2", LoadSceneMode.Single);
        }
        // Check if the collided object has the name "P_PotionBlue3"
        if (collision.gameObject.name == "P_PotionBlue3")
        {
            // Load scene3 asynchronously
            SceneManager.LoadSceneAsync("scene3", LoadSceneMode.Single);
        }
        // Check if the collided object has the tag "quit"
        else if (collision.gameObject.tag == "quit")
        {
            // Quit the application
            Application.Quit();
            // Stop playing in the Unity editor
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
