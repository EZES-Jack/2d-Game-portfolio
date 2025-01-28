using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpspeed = 8f;
    private float direction = 0f;
    private Rigidbody2D player;
    
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private Vector3 respawnPoint;
   
    public GameObject FallDetector;
    
    public Text scoreText;
    public Text deathsText;
    public Text timerText;
    public Text resultsText;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
        scoreText.text = "Score: " + Scoring.totalScore;
        deathsText.text = "Deaths: " + Deaths.deaths;
        timerText.text = "time: " + Timer.timer;
        resultsText.text = "results: " + results.Results;

    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        FallDetector.transform.position = new Vector2(transform.position.x, FallDetector.transform.position.y);
        if (1 == 1)
        {
            Timer.timer += 1;
            timerText.text = "Time: " + Timer.timer;
        }

        direction = Input.GetAxis("Horizontal");
        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector2(player.velocity.x, jumpspeed);
        }
        


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
        else if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }
        else if (collision.tag == "P_PotionBlue2")
        {
            Scoring.totalScore += 1;
            Debug.Log(Scoring.totalScore += 1);
            collision.gameObject.SetActive(false);
            scoreText.text = "Score: " + Scoring.totalScore;
        }
        else if (collision.tag == "level3")
        {
            Scoring.totalScore += 2;
            Debug.Log(Scoring.totalScore += 1);
            collision.gameObject.SetActive(false);
            scoreText.text = "Score: " + Scoring.totalScore;
            SceneManager.LoadSceneAsync("scene3", LoadSceneMode.Single);
            Scoring.totalScore -= 1;
        }

        else if (collision.tag == "end game +3")
        {
            Scoring.totalScore += 3;
            collision.gameObject.SetActive(false);
            scoreText.text = "Score: " + Scoring.totalScore;
            SceneManager.LoadSceneAsync("results", LoadSceneMode.Single);
            results.Results = (Timer.timer / Deaths.deaths) * Scoring.totalScore;
            resultsText.text = "results: " + results.Results;

        }
        else if (collision.tag == "end game+10")
        {
            Scoring.totalScore += 10;
            collision.gameObject.SetActive(false);
            scoreText.text = "Score: " + Scoring.totalScore;
            SceneManager.LoadSceneAsync("results", LoadSceneMode.Single);
            results.Results = (Timer.timer / Deaths.deaths) * Scoring.totalScore;
            resultsText.text = "results: " + results.Results;

        }
    }
}


