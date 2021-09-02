using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public static Action OnHourChanged;
    public static Action OnDayChanged;
    public static Action OnWeekChanged;
    public static Action OnMonthChanged;
    public static Action OnYearChanged;

    public static int Hour { get; private set; }
    public static int Day { get; private set; }
    public static int Week { get; private set; }
    public static int Month { get; private set; }
    public static int Year { get; private set; }

    public static bool TownScale = true;
    public static bool WorldScale = false;

    private static string[] monthNames = new string[] {"0", "January", "February", "March", "April", "May",
        "June", "July", "August", "September", "October", "November", "December", "0"};

    private static string[] dayNames = new string[] { "0", "Monday", "Tuesday", "Wednesday", "Thursday", 
        "Friday", "Saturday", "Sunday", "8" };

    private float timer;

    public static float HourToRealTime
    {
        get
        {
            if (TownScale && !WorldScale)
            {
                return 10f;
            }
            else if(WorldScale && !TownScale){
                return 0.3f;
            }
            else
            {
                return 10f;
            }
        }
    }
    public static string GetMonthName
    {
        get
        {
            return monthNames[Month];
        }
    }
    public static string GetDayName
    {
        get
        {
            return dayNames[Day];
        }
    }

    void Start()
    {
        Hour = 9;
        Day = 3;
        Week = 1;
        Month = 6;
        Year = 1522;
    }

    void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Hour++;
            timer = HourToRealTime;
            OnHourChanged?.Invoke();
            if (Hour >= 24)
            {
                Day++;
                Hour = 0;
                OnDayChanged?.Invoke();
                if (Day > 7)
                {
                    Week++;
                    Day = 1;
                    OnWeekChanged?.Invoke();
                    if(Week > 4)
                    {
                        Week = 1;
                        Month++;
                        OnMonthChanged?.Invoke();
                        if (Month > 12)
                        {
                            Year++;
                            Month = 1;
                            OnYearChanged?.Invoke();
                        }
                    }
                }
            }
        }
    }
}
