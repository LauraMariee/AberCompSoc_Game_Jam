using UnityEngine;

namespace Controller
{
    public class PCController : MonoBehaviour
    {

        public int currentSatisfaction;
        private int _minSatisfaction;
        private int _maxSatisfaction = 10;

        private float _timeRemaining = 3;

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
                    _timeRemaining = 1;
                }
                else
                {
                    currentSatisfaction--;
                    Debug.Log("Reset");
                    _timeRemaining = 1;
                }
            }

            if (currentSatisfaction == _maxSatisfaction)
            {
                UnityEngine.Debug.Log("Work has been done");
            }
        }
    }
}
