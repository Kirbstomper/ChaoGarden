using UnityEngine;
using System.Collections;

public class Food : Item {
    public int pow; //Power
    public int run; //RUn
    public int fly; // Fly
    public int sta; //Stamina
    public int swm; // Swin
    public float hungerVal;
    
    void Start () {
        pow = 0;
        run = 4;
        fly = 0;
        sta = 4;
        swm = 0;
        hungerVal = .6f;
        //item_id = 0;

        string json = JsonUtility.ToJson(this);
        print(json);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
