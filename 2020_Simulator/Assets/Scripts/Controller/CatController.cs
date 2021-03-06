﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private int damage = 1;

    public int currentSatisfaction;
    private int minSatisfaction = 2;
    private int maxSatisfaction = 10;

    private float timeRemaining = 5;

    public GameObject panel;

    public EnvironmentController environmentController;

    // Start is called before the first frame update
    void Start()
    {
        currentSatisfaction = 4; //out of 10
    }

    public void OnMouseDown()
    {
        if (currentSatisfaction <= maxSatisfaction)//stop at max 
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
            if(currentSatisfaction == 0)
            {
                panel.SetActive(true);
                Debug.Log("Reset");
                timeRemaining = 5;
            }
            else if (currentSatisfaction == minSatisfaction)
            {
                environmentController.health = environmentController.health - damage;
                panel.SetActive(true); 
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
            panel.SetActive(false);
            UnityEngine.Debug.Log("Cat is happy");
        }
    }
}
