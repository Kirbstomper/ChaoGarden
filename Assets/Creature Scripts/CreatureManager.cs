using UnityEngine;
using System.Collections;

/*
 * This is the class that will manage all creatues currently under the players care.
 * This mostly amounts to againg creatures and keeping their statistics when the game is saved (?)
 */
public class CreatureManager : MonoBehaviour {
   
    public Simple_Creature[] stable;
    // Use this for initialization
    void Start() {
      
        stable = new Simple_Creature[3];
    }


    // Age the creature whenever this method is called.
    public void AgeCreatures()
    {
        for (int i = 0; i < stable.Length; i++)if(stable[i] != null) stable[i].AgeSelf();

    }

    public void AddCreature(Simple_Creature c) {
         for(int i = 0; i < stable.Length; i++)
        {
              if(stable[i]== null) { stable[i] = c; break; }

        }
    }
	// Update is called once per frame
	void Update () {
	   
	}
}
