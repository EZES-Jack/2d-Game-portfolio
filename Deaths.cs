using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deaths : MonoBehaviour
{
    public static int deaths;                              
    public Text deathsText;                             
    private Vector3 respawnPoint;                 
    public GameObject FallDetector;               
    private Rigidbody2D player;                          


    void Start()
    {
        respawnPoint = transform.position;                  
        deathsText.text = "Deaths: " + Deaths.deaths;     
        player = GetComponent<Rigidbody2D>();              
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "waterfall")
        {
            transform.position = respawnPoint;
            Deaths.deaths += 1;
            Debug.Log(Deaths.deaths);
            deathsText.text = "Deaths: " + Deaths.deaths;
        }
        if (collision.gameObject.tag == "FallDetector")
        {
            transform.position = respawnPoint;
            Deaths.deaths += 1;
            Debug.Log(Deaths.deaths);
            deathsText.text = "Deaths: " + Deaths.deaths;
        }
    }
}
