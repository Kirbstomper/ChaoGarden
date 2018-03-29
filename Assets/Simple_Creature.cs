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
    public int age; // Age of creature
    public float hungerMax;
    public float hungedFilled;
	// Randomizes stats on creation of chao for variety/SOFT RESETS
	void Start () {
        pow_stat = Random.Range(1, 5);
        run_stat = Random.Range(1, 5);
        fly_stat = Random.Range(1, 5);
        swm_stat = Random.Range(1, 5);
        sta_stat = Random.Range(1, 5);
        int_stat = Random.Range(1, 5);
        luc_stat = Random.Range(1, 5);
        age = 0;
        hungedFilled = 0;
        hungerMax = 1f;
    }
	
	// Update is called once per frame
	void Update () {
        // Scan for food

        if (hungedFilled < hungerMax)
        {

            Food[] foodlist = FindObjectsOfType<Food>();
            if (foodlist.Length > 0)
            {
                float speed = run_stat * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, foodlist[0].transform.position, speed);
                if (transform.position == foodlist[0].transform.position) eat(foodlist[0]);
            }
        }
	}

    void eat(Food f)
    {
        pow_stat += f.pow;
        run_stat += f.run;
        fly_stat += f.fly;
        swm_stat += f.swm;
        sta_stat += f.sta;
        hungedFilled += f.hungerVal;
        DestroyObject(f.gameObject);
    }
}
