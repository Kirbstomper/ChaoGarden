using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;

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

    public static int CanEvolve(Simple_Creature c)
    {
        

        string path = "Assets/Resources/Creatures.json";
        AssetDatabase.ImportAsset(path);
        TextAsset file = (TextAsset)Resources.Load("Creatures");
        Debug.Log(file.text);
        //gets the table

        Creature [] j = new Creature[3];
        j[0] = new Creature(0,"egg");
        j[1] = new Creature(1,"nerd");
        j[2] = new Creature(2,"test");

        string jArray = JsonHelper.ToJson(j);
       Debug.Log(jArray);

        j = JsonHelper.FromJson<Creature>(file.text);
        Debug.Log(j[2].species);
    


        //if cannot evolve
        return -1;

    }
}
[System.Serializable]
class JsonTest
{
    public int id;

    public JsonTest(int i) { id = i; }
}
