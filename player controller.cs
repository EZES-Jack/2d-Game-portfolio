using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Player movement speed
    public float speed = 5f;
    // Player jump speed
    public float jumpspeed = 8f;
    // Horizontal direction input
    private float direction = 0f;
    // Rigidbody2D component of the player
    private Rigidbody2D player;
    // Transform component to check if the player is on the ground
    public Transform groundCheck;
    // Radius of the ground check circle
    public float groundCheckRadius;
    // Layer mask to detect ground layer
    public LayerMask groundLayer;
    // Boolean to check if the player is touching the ground
    private bool isTouchingGround;
    // Respawn point for the player
    private Vector3 respawnPoint;
    // Fall detector game object
    public GameObject FallDetector;

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        player = GetComponent<Rigidbody2D>();
        // Set the initial respawn point to the player's starting position
        respawnPoint = transform.position;
    }

    void Update()
    {
        // Check if the player is touching the ground
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        // Update the fall detector position to follow the player
        FallDetector.transform.position = new Vector2(transform.position.x, FallDetector.transform.position.y);

        // Get horizontal input
        direction = Input.GetAxis("Horizontal");
        if (direction > 0f)
        {
            // Move player to the right
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else if (direction < 0f)
        {
            // Move player to the left
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else
        {
            // Stop player horizontal movement
            player.velocity = new Vector2(0, player.velocity.y);
        }
        // Make the player jump if the jump button is pressed and the player is on the ground
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector2(player.velocity.x, jumpspeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Checkpoint")
        {
            // Update respawn point to the current position when hitting a checkpoint
            respawnPoint = transform.position;
        }
        else if (collision.tag == "P_PotionBlue2")
        {
            // Deactivate the blue potion game object when collected
            collision.gameObject.SetActive(false);
        }
        else if (collision.tag == "level3")
        {
            // Deactivate the level 3 trigger and load scene 3
            collision.gameObject.SetActive(false);
            SceneManager.LoadSceneAsync("scene3", LoadSceneMode.Single);
        }
        else if (collision.tag == "end game +3")
        {
            // Deactivate the end game +3 trigger
            collision.gameObject.SetActive(false);
        }
        else if (collision.tag == "end game+10")
        {
            // Deactivate the end game +10 trigger and load results scene
            collision.gameObject.SetActive(false);
            SceneManager.LoadSceneAsync("results", LoadSceneMode.Single);
        }
    }
}
