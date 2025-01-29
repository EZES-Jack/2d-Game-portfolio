using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    int scene;

    // Start is called before the first frame update
    void Start()
    {
 
    }
     
    // Update is called once per frame
    void Update()
    {
 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "P_PotionBlue")
        {
            SceneManager.LoadSceneAsync("scene1",LoadSceneMode.Single);
            Scoring.totalScore = 0;
            Timer.timer = 0;
        }
        if (collision.gameObject.tag == "P_PotionBlue2")
        {
            SceneManager.LoadSceneAsync("scene2", LoadSceneMode.Single);
            Scoring.totalScore -= 1;
        }
        if (collision.gameObject.name == "P_PotionBlue3")
        {
            SceneManager.LoadSceneAsync("scene3", LoadSceneMode.Single);
            Scoring.totalScore -= 1;
        }

        else if (collision.gameObject.tag == "quit" )
            {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
            Debug.Log("quit");
            }
    }
}
