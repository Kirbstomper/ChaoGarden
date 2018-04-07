using UnityEngine;
using System;

public class TimeDateController : MonoBehaviour {
    //private static Time currentTime = new Time();
    private static int month;
    public struct game_time
    {
        public int hour;
        public int minute;
        public int second;

        public game_time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
    }
    private game_time currentTime = new game_time(-1, -1, -1);
    private static int day = -1;
    private static int season = -1;
    private enum Seasons {SPRING, SUMMER,FALL, WINTER };
   
	// Use this for initialization
	void Start () {
        if (season == -1)
        {
            season = (int)(Seasons.WINTER);//Start game in spring
        }
        if (day == -1)
        {
            day = 30;
        }
        if (currentTime.hour == -1) { currentTime = new game_time(23, 55, 0); }
       
        
	}
	
	// Update is called once per frame
	void Update () {
        currentTime.second++;
        if(currentTime.second == 60)
        {
            currentTime.minute++;
            currentTime.second = 0;
        }
        if (currentTime.minute == 60)
        {
            currentTime.minute = 0;
            currentTime.hour++;
        }
        if(currentTime.hour == 24)
        {
            currentTime.hour = 0;
            AddDay();
        }
	}

    //Updates the season to the proper next value;
    void ChangeSeason()
    {
        if (season == 3) season = 0;
        else { season++; }

    }
    //Adds a new day when the time clicks over, or a new day is started
    void AddDay()
    {
        if (day + 1 == 31) { ChangeSeason(); day = 1; }
        else { day++; }
    }



    //Returns a string representation of the season
    public string GetSeason()
    {
        switch (season)
        {
            case (int)Seasons.FALL:
                return "Fall";
            case (int)Seasons.SPRING:
                return "Spring";
            case (int)Seasons.SUMMER:
                return "Summer";
            case (int)Seasons.WINTER:
                return "Winter";
            default:
                return "DATE ERROR FUNTION GetSeason()";
        }

    }

    //Returns the current season and day in a human readable format
    public string GetDateFormatted()
    {

        return "Season: " + GetSeason() + " Day:" + day;
    }

    public string GetTimeFormmated()
    {
        return "Time: " + currentTime.hour + ":" + currentTime.minute;
    }

}
