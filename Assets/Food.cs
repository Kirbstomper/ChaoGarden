using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
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
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
