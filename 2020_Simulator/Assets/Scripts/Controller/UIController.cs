using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Controller
{
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


        private void Update()
        {

            //update the label value
            timerLabel.text = environmentController.timeRemaining.ToString(CultureInfo.CurrentCulture);

            catLabel.text = cat.currentSatisfaction.ToString();
            workLabel.text = pC.currentSatisfaction.ToString();
            foodLabel.text = plateController.currentSatisfaction.ToString();
            healthLabel.text = environmentController.health.ToString(); 
        }


        public void Restart()
        {
            SceneManager.LoadScene("Game");
        }

        public void Start()
        {
            //SceneManager.LoadScene("Game");
        }


        //check time after a while and end game
    }
}