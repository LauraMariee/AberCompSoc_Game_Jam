﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCController : MonoBehaviour
{

    public int currentSatisfaction;
    private int minSatisfaction;
    private int maxSatisfaction = 10;


    public void OnMouseDown()
    {
        if (currentSatisfaction < maxSatisfaction)//stop at max 
        {
            currentSatisfaction++; //increase satisfaction
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSatisfaction == maxSatisfaction)
        {
            UnityEngine.Debug.Log("Work has been done");
        }
    }
}
