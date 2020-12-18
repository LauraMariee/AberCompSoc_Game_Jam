using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public Button yourButton;

    void Update()
    {

        //update the label value
        timerLabel.text = environmentController.timeRemaining.ToString();

        catLabel.text = cat.currentSatisfaction.ToString();
        workLabel.text = pC.currentSatisfaction.ToString();
        foodLabel.text = plateController.currentSatisfaction.ToString();
        healthLabel.text = environmentController.health.ToString(); 
    }


    public void restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void start()
    {
        SceneManager.LoadScene("Game");
    }


    //check time after a while and end game
}