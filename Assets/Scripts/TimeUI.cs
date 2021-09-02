using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void OnEnable()
    {
        TimeManager.OnHourChanged += UpdateClock;
        TimeManager.OnDayChanged += UpdateClock;
        TimeManager.OnWeekChanged += UpdateClock;
        TimeManager.OnMonthChanged += UpdateClock;
        TimeManager.OnYearChanged += UpdateClock;
    }

    private void OnDisable()
    {
        TimeManager.OnHourChanged -= UpdateClock;
        TimeManager.OnDayChanged -= UpdateClock;
        TimeManager.OnWeekChanged -= UpdateClock;
        TimeManager.OnMonthChanged -= UpdateClock;
        TimeManager.OnYearChanged -= UpdateClock;
    }

    private void UpdateClock()
    {
        timeText.text = $"{TimeManager.Hour:00}H\n{TimeManager.GetDayName} " +
            $"\n{TimeManager.Week} week of {TimeManager.GetMonthName}\n{TimeManager.Year}";
    }


}
