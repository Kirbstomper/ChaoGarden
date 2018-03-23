using UnityEngine;
using System.Collections;

public class Simple_Creature : MonoBehaviour {
   // Stats copied from chao garden
    public int pow_stat; //Power
    public int run_stat; //RUn
    public int fly_stat; // Fly
    public int sta_stat; //Stamina
    public int swm_stat; // Swin
    private int int_stat; // Intelligence: hidden from view
    private int luc_stat; // luck: Hidden from view
   
	// Randomizes stats on creation of chao for variety/SOFT RESETS
	void Start () {
        pow_stat = Random.Range(1, 5);
        run_stat = Random.Range(1, 5);
        fly_stat = Random.Range(1, 5);
        swm_stat = Random.Range(1, 5);
        sta_stat = Random.Range(1, 5);
        int_stat = Random.Range(1, 5);
        luc_stat = Random.Range(1, 5);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
