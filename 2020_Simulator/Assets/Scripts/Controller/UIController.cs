using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public CatController cat;
    public PCController pC;
    public PlateController plateController; 

    public Text timerLabel;
    public Text catLabel;
    public Text workLabel;
    public Text foodLabel;

    public Text health;

    private float time;

    void Update()
    {
        time += Time.deltaTime;

        var minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
        var seconds = time % 60;//Use the euclidean division for the seconds.
        var fraction = (time * 100) % 100;

        //update the label value
        timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);

        catLabel.text = cat.currentSatisfaction.ToString();
        workLabel.text = pC.currentSatisfaction.ToString();
        foodLabel.text = plateController.currentSatisfaction.ToString(); 
    }

    //check time after a while and end game
}