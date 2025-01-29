using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timer;
    public Text timerText;

    void Start()
    {
        timerText.text = "time: " + Timer.timer;
    }

    void Update()
    {
        Timer.timer = Time.time;
        timerText.text = "Time: " + Mathf.RoundToInt(Timer.timer);
    }
    
}
