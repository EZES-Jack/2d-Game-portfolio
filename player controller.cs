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
    

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        FallDetector.transform.position = new Vector2(transform.position.x, FallDetector.transform.position.y);

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
        if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }
        else if (collision.tag == "P_PotionBlue2")
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.tag == "level3")
        {
            collision.gameObject.SetActive(false);
            SceneManager.LoadSceneAsync("scene3", LoadSceneMode.Single);
        }

        else if (collision.tag == "end game +3")
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.tag == "end game+10")
        {
            collision.gameObject.SetActive(false);
            SceneManager.LoadSceneAsync("results", LoadSceneMode.Single);
        }
    }
}



