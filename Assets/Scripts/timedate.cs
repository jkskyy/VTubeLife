using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timedate : MonoBehaviour, IDataPersistence
{
    public int hour, minute, day, month, year;
    public Text days, months, years, hours, minutes;
    public GameObject StatsPanel;

    public void LoadData(GameData gameData)
    {
        this.hour = gameData.hour;
        this.minute = gameData.minute;
        this.day = gameData.day;
        this.month = gameData.month;
        this.year = gameData.year;
    }

    public void SaveData(GameData gameData)
    {
        gameData.hour = this.hour;
        gameData.minute = this.minute;
        gameData.day = this.day;
        gameData.month = this.month;
        gameData.year = this.year;
    }

    void Start()
    {
        InvokeRepeating("Time", 0, 1);
        Invoke("Stats", 1);
    }

    public void Time()
    {
        if (minute < 59)
        {
            minute = Mathf.Clamp(minute + 1, 0, 60);
        }
        else if (hour < 23)
        {
            minute = 0;
            hour += 1;
        }
        else if (day < 30)
        {
            hour = 0;
            minute = 0;
            day += 1;
        }
        else if (month < 12)
        {
            hour = 0;
            minute = 0;
            day = 1;
            month += 1;
        }
        else
        {
            year += 1;
        }
        if (minute >= 10) minutes.text = minute.ToString(); else minutes.text = "0" + minute.ToString();
        if (hour >= 10) hours.text = hour.ToString(); else hours.text = "0" + hour.ToString();
        if (day >= 10) days.text = day.ToString(); else days.text = "0" + day.ToString();
        if (month >= 10) months.text = month.ToString(); else months.text = "0" + month.ToString();
        years.text = year.ToString();
    }

    public void CheckTime()
    {
        if (minute > 59)
        {
            minute = 0;
            hour += 1;
        }
        if(hour > 24)
        {
            hour = 0;
            day += 1;
        }
        if(day > 30)
        {
            day = 1;
            month += 1;
        }
        if(month > 12)
        {
            month += 1;
            year += 1;
        }
        if (minute >= 10) minutes.text = minute.ToString(); else minutes.text = "0" + minute.ToString();
        if (hour >= 10) hours.text = hour.ToString(); else hours.text = "0" + hour.ToString();
        if (day >= 10) days.text = day.ToString(); else days.text = "0" + day.ToString();
        if (month >= 10) months.text = month.ToString(); else months.text = "0" + month.ToString();
        years.text = year.ToString();
    }

    void Stats()
    {
        StatsPanel.SetActive(true);
    }
}
