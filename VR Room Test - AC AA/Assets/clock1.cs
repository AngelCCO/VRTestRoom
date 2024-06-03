using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class clock1 : MonoBehaviour
{
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;
    [SerializeField] Transform hoursPivot;
    [SerializeField] Transform minutesPivot;
    [SerializeField] Transform secondsPivot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(hoursToDegrees * (float)time.TotalHours, 0f, 0f);
        minutesPivot.localRotation = Quaternion.Euler(minutesToDegrees * (float)time.TotalMinutes, 0f, 0f);
        secondsPivot.localRotation = Quaternion.Euler(secondsToDegrees * (float)time.TotalSeconds, 0f, 0f);
    }
}
