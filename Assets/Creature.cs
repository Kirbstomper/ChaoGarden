using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;

public class Creature : MonoBehaviour {
   
    /* This method will return the species ID of whatever the passed creature can evolve into*/

	public static int CanEvolve(Simple_Creature c)
    {
        string path = "Assets/Resources/Creatures.json";
        AssetDatabase.ImportAsset(path);
        TextAsset file = (TextAsset)Resources.Load("Creatures");
        Debug.Log(file.text);
        //gets the table

        //ArrayList  evo = new ArrayList<Evolution>();




        //if cannot evolve
        return -1;

    }
}
