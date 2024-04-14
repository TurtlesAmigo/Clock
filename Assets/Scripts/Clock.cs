using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float HOURS_TO_DEGREES = -30f;
    const float MINUTES_TO_DEGREES = -6f;
    const float SECONDS_TO_DEGREES = -6f;

    [SerializeField]
    Transform HoursPivot;
    [SerializeField]
    Transform MinutesPivot;
    [SerializeField]
    Transform SecondsPivot;

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        HoursPivot.localRotation =
            Quaternion.Euler(0f, 0f, HOURS_TO_DEGREES * (float) time.TotalHours);
        MinutesPivot.localRotation =
            Quaternion.Euler(0f, 0f, MINUTES_TO_DEGREES * (float) time.TotalMinutes);
        SecondsPivot.localRotation =
            Quaternion.Euler(0f, 0f, SECONDS_TO_DEGREES * (float) time.TotalSeconds);
    }
}
