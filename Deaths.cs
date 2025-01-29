using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deaths : MonoBehaviour
{
    public static int deaths;                               //defining the death count
    public Text deathsText;                                 //defining the text file
    private Vector3 respawnPoint;                           //defines the original spawn point
    public GameObject FallDetector;                         //initalises the fall detector
    private Rigidbody2D player;                             //initalises the players collider

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;                  //sets the original spawn point
        deathsText.text = "Deaths: " + Deaths.deaths;       //displays the deaths text
        player = GetComponent<Rigidbody2D>();               //finds the player collider
    }

    // Update is called once per frame
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
