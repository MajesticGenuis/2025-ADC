using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TimeKeeper;

public class TimeKeeper : MonoBehaviour
{
    public float SimulationTime { get; private set; }
    public float PlaySpeed { get; private set; } = 1f;
    public bool IsPaused { get; private set; } = false;

    public static event Action<float> OnTimeUpdated;

    private void Update()
    {
        if (!IsPaused)
        {
            SimulationTime += Time.deltaTime * PlaySpeed;
            OnTimeUpdated?.Invoke(SimulationTime);
        }
    }

    public void SetPlaySpeed(Slider slider)
    {
        PlaySpeed = slider.value;
    }

    public void Pause()
    {
        IsPaused = true;
    }

    public void Play()
    {
        IsPaused = false;
    }
    public void SetSimulationTime(float targetTime)
    {
        SimulationTime = targetTime;
    }
}
