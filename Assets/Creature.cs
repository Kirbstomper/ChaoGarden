using UnityEngine;
using System.Collections;
using System.IO;


[System.Serializable]
public class Creature{

    public int id;
    public string species;
    public Evolution [] evolution;

    public Creature(int i, string s)
    {
        id = i;
        species = s;
    }


    /* This method will return the species ID of whatever the passed creature can evolve into*/

    public static void CheckEvolve(Simple_Creature c)
    {
        

        string path = "Assets/Resources/Creatures.json";
        string data = File.ReadAllText(path);
      //  TextAsset file = (TextAsset)Resources.Load("Creatures");
        Debug.Log(data);
        //gets the table

        Creature [] j = new Creature[3];
        j[0] = new Creature(0,"egg");
        j[1] = new Creature(1,"nerd");
        j[2] = new Creature(2,"test");

        string jArray = JsonHelper.ToJson(j);
       Debug.Log(jArray);

        j = JsonHelper.FromJson<Creature>(data);
        Debug.Log(j[c.species_id].evolution.Length);
        Evolution[] possibles = j[c.species_id].evolution;

        //Check through evolutions to see if it satisfys any
        int toEvolve = Evolution.getEvolution(possibles, c);

        //If evolution found
        if (toEvolve != -1)
        {
            c.species_id = j[toEvolve].id;
            c.species = j[toEvolve].species;
        }
        

    }
}
[System.Serializable]
class JsonTest
{
    public int id;

    public JsonTest(int i) { id = i; }
}
