using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Static variable to keep track of the elapsed time
    public static float timer;
    // UI Text component to display the timer
    public Text timerText;

    void Start()
    {
        // Initialize the timerText with the current timer value
        timerText.text = "time: " + Timer.timer;
    }

    void Update()
    {
        // Update the timer with the time elapsed since the start of the game
        Timer.timer = Time.time;
        // Update the timerText with the rounded timer value
        timerText.text = "Time: " + Mathf.RoundToInt(Timer.timer);
    }
}
