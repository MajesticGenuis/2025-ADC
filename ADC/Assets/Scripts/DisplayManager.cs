using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour
{
    public Text timeText;
    void OnEnable()
    {
        TimeKeeper.OnTimeUpdated += HandleTimeUpdate;
    }

    private void HandleTimeUpdate(float simulationTime)
    {
        
        updateTimeText(simulationTime);
    }

    private void updateTimeText(float simulationTime)
    {
        int seconds;
        int minutes;
        string secondsText;
        string minutesText;
        
        seconds = (int)simulationTime;
       
        minutes = seconds / 60;
        seconds -= minutes * 60;
       
        secondsText = seconds.ToString();
        minutesText = minutes.ToString();
        if (seconds < 10)
        {
            secondsText = "0"+ seconds.ToString();
        }
        if (minutes < 10)
        {
            minutesText = "0" + minutes.ToString();
        }
        timeText.text = minutesText + ":" + secondsText;

    }
}
