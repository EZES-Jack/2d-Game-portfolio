using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Transform component of the player to follow
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // Set the camera position to follow the player's position
        // The z-axis is set to -10 to keep the camera at a distance from the player
        transform.position = new Vector3(player.position.x, player.position.y, -10);
    }
}
