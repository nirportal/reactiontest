using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerReady : MonoBehaviour
{   
    public Text timerText;
    float startTime;
    bool haspreseed = false;
    bool test = false;
    bool hasStarted = false;


    void Update()
    {
        if (Input.anyKey && hasStarted == false)
        {
            timerText.text = "first test is about reaction time,\n try to press the left mouse butten when the backgroun turns red \n as fast as you can! \n press the 'g' key to start";
            hasStarted = true;         
        }
        if (hasStarted = true && Input.GetKey("g"))
        {
            inTest();
        }

    }


    void inTest()
    {
        if (haspreseed == false && hasStarted == true)
        {
            startTime = Time.time;
            haspreseed = true;
            test = true;
        }
        if (test)
        {
            setTimer();
        }
    }


    void setTimer()
    {
        if (haspreseed)
        {
            float t = Time.time - startTime;
            string seconds = (t % 60).ToString("f3");
            timerText.text = seconds;
        }
    }
}
