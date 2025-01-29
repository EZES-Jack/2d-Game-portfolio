using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static int totalScore;                             //defining the score
    public Text scoreText;                                    //defining the text file

    void Start()
    {
        scoreText.text = "Score: " + Scoring.totalScore;      //initialises the script so the score is displayed as 0
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "P_PotionBlue2")                  //checks for a collision with the object that ends the level
        {                                                      
            Scoring.totalScore += 1;                           //adds 1 point to total score
            scoreText.text = "Score: " + Scoring.totalScore;   //changes the display showing score change
        }
        else if (collision.tag == "level3")                    //checks for a collision with the object that ends the level
        {
            Scoring.totalScore += 1;                           //adds 1 point to total score
            scoreText.text = "Score: " + Scoring.totalScore;   //changes the display showing score change

        }

        else if (collision.tag == "end game +3")               //checks for a collision with the object that ends the level
        {
            Scoring.totalScore += 3;                           //adds 3 points to total score
            scoreText.text = "Score: " + Scoring.totalScore;   //changes the display showing score change

        }
        else if (collision.tag == "end game+10")              //checks for a collision with the object that ends the level
        {
            Scoring.totalScore += 10;                         //adds 10 points to total score
            scoreText.text = "Score: " + Scoring.totalScore;  //changes the display showing score change

        }
    }
}
