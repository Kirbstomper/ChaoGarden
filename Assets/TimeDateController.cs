using UnityEngine;
using System;

public class TimeDateController : MonoBehaviour {
    private Time currentTime = new Time();
    private int month;
    private int day;
    private int season;
    private enum Seasons {SPRING, SUMMER,FALL, WINTER };
   
	// Use this for initialization
	void Start () {
        season = (int)(Seasons.SPRING);//Start game in spring
	}
	
	// Update is called once per frame
	void Update () {
	    
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

}
