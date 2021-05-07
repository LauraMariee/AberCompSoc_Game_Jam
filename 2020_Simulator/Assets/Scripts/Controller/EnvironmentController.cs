using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controller
{
    public class EnvironmentController : MonoBehaviour
    {

        public float timeRemaining;
        public int health;

        public GameObject fire;
        public GameObject fire2;
        public GameObject fire3;
        public GameObject fire4;

        public enum Level
        {
            LevelOne,
            LevelTwo,
            LevelThree
        };

        public Level level = new Level();

        // Start is called before the first frame update
        void Start()
        {
            health = 5;
            level = Level.LevelOne;
            timeRemaining = LevelManagerTime();
        }


        private int LevelManagerTime()
        {
            if (level == Level.LevelOne)
            { 
                var levelOneTime = 60;
                return levelOneTime; 
            }
            //else if (level == Level.levelTwo)
            //{
            //    int levelTwoTime = 30;
            //    return levelTwoTime;
            //}
            //else if (level == Level.levelThree)
            //{
            //    int levelThreeTime = 40;
            //    return levelThreeTime; 
            //}
            else
            {
                return 0; 
            }
        }



        // Update is called once per frame
        void Update()
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            if(timeRemaining < 60)
            {
                fire.SetActive(true);
            }
            if (timeRemaining < 50)
            {
                fire2.SetActive(true);
            }
            if (timeRemaining < 40)
            {
                fire3.SetActive(true);
            }
            if (timeRemaining < 30)
            {
                fire4.SetActive(true);
            }
            else
            {
                //LevelEnd(); 
            }

            if(health == 0)
            {
                LevelEnd(); 
            }
        }

        private static void LevelEnd()
        {
            SceneManager.LoadScene("GameOver");
        }

        public void Congratulations()
        {
            SceneManager.LoadScene("Congrats");
        }
    }
}
