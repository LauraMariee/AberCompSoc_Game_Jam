using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnvironmentController : MonoBehaviour
{

    public float timeRemaining = 120000000;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 5; 
    }

    // Update is called once per frame
    void Update()
    {        
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            LevelEnd(); 
        }

        if(health == 0)
        {
            LevelEnd(); 
        }
    }

    public void LevelEnd()
    {
        SceneManager.LoadScene("GameOver"); 
        UnityEngine.Debug.Log("Game Over");
    }
}
