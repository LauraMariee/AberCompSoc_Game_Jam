using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{
    public int currentSatisfaction;
    private int minSatisfaction;
    private int maxSatisfaction = 10;

    private float timeRemaining = 5;

    // Start is called before the first frame update
    void Start()
    {
        currentSatisfaction = 2; //out of 10
    }

    public void OnMouseDown()
    {
        if (currentSatisfaction < maxSatisfaction)//stop at max 
        {
            currentSatisfaction++; //increase satisfaction
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            if (currentSatisfaction == 0)
            {
                Debug.Log("Reset");
                timeRemaining = 5;
            }
            else
            {
                currentSatisfaction--;
                Debug.Log("Reset");
                timeRemaining = 5;
            }
        }

        if (currentSatisfaction == maxSatisfaction)
        {
            UnityEngine.Debug.Log("No more food!"); 
        }
    }
}
