﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    public int damage;


    public int currentSatisfaction;
    private int minSatisfaction;
    private int maxSatisfaction = 10;


    public void OnMouseDown()
    {
        if(currentSatisfaction < maxSatisfaction)//stop at max 
        {
            currentSatisfaction++; //increase satisfaction
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        currentSatisfaction = 2; //out of 10
    }

    public void catAttack()
    {
        //damage player 
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSatisfaction <= minSatisfaction)
        {
            catAttack(); 
        } 
    }
}
