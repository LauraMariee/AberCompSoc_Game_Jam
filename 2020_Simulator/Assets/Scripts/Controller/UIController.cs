using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public CatController cat;
    public PCController pC;
    public PlateController plateController;
    public EnvironmentController environmentController; 

    public Text timerLabel;
    public Text catLabel;
    public Text workLabel;
    public Text foodLabel;

    public Text healthLabel;

    private float time;

    void Update()
    {

        //update the label value
        timerLabel.text = environmentController.timeRemaining.ToString();

        catLabel.text = cat.currentSatisfaction.ToString();
        workLabel.text = pC.currentSatisfaction.ToString();
        foodLabel.text = plateController.currentSatisfaction.ToString();
        healthLabel.text = environmentController.health.ToString(); 
    }

    //check time after a while and end game
}