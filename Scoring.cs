using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static int totalScore;                         
    public Text scoreText;                                   

    void Start()
    {
        scoreText.text = "Score: " + Scoring.totalScore;      
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "P_PotionBlue2")                  
        {                                                      
            Scoring.totalScore += 1;                          
            scoreText.text = "Score: " + Scoring.totalScore;   
        }
        else if (collision.tag == "level3")                 
        {
            Scoring.totalScore += 1;                          
            scoreText.text = "Score: " + Scoring.totalScore;   

        }

        else if (collision.tag == "end game +3")             
        {
            Scoring.totalScore += 3;                         
            scoreText.text = "Score: " + Scoring.totalScore;  

        }
        else if (collision.tag == "end game+10")              
        {
            Scoring.totalScore += 10;                         
            scoreText.text = "Score: " + Scoring.totalScore; 

        }
    }
}
