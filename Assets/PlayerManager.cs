using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
   public int zenny;// The players amount of money
    public Item[] inventory;
    const int INV_SIZE = 20; //Inventory size
	// Use this for initialization
	void Start () {
        inventory = new Item[INV_SIZE];
        zenny = 500;
        for(int i = 0; i < INV_SIZE;i++)
        {
            inventory[i] = new Food();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    
   
}
