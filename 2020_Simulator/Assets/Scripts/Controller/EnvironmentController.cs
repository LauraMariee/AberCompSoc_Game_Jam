using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{

    public float timeRemaining = 1200;


    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    public void LevelEnd()
    {
        UnityEngine.Debug.Log("Game Over");
    }
}
