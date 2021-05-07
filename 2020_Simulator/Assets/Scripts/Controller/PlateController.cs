using UnityEngine;

namespace Controller
{
    public class PlateController : MonoBehaviour
    {
        public int currentSatisfaction;
        private int _minSatisfaction;
        private int _maxSatisfaction = 10;

        private float _timeRemaining = 1;

        // Start is called before the first frame update
        private void Start()
        {
            currentSatisfaction = 3; //out of 10
        }

        public void OnMouseDown()
        {
            if (currentSatisfaction < _maxSatisfaction)//stop at max 
            {
                currentSatisfaction++; //increase satisfaction
            }
        }

        // Update is called once per frame
        private void Update()
        {
            if (_timeRemaining > 0)
            {
                _timeRemaining -= Time.deltaTime;
            }
            else
            {
                if (currentSatisfaction == 0)
                {
                    Debug.Log("Reset");
                    _timeRemaining = 2;
                }
                else
                {
                    currentSatisfaction--;
                    Debug.Log("Reset");
                    _timeRemaining = 2;
                }
            }

            if (currentSatisfaction == _maxSatisfaction)
            {
                UnityEngine.Debug.Log("No more food!"); 
            }
        }
    }
}
