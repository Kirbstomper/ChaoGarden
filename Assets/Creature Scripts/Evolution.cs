using UnityEngine;
using System.Collections;

[System.Serializable]
public class Evolution {
    public int id; //Species ID;
    public int age;//Age
    public int pow; //Power
    public int run; //RUn
    public int swm; // Swim
    public int fly; // Fly
    public int sta; //Stamina
    public int intel; // Intelligence
    public int luc; // Luck
    


    public static int getEvolution(Evolution [] e, Simple_Creature c)
    {
        int[] match = new int[e.Length];
        
        for(int i = 0; i < e.Length; i++)
        {
            Evolution evo = e[i];
            if ((c.age >= evo.age) && (c.pow_stat >= evo.pow) &&
                (c.run_stat >= evo.run) && (c.swm_stat >= evo.swm)
                && (c.fly_stat >= evo.fly) && (c.sta_stat >= evo.sta)
                && (c.int_stat >= evo.intel) && (c.luc_stat >= evo.luc)
                )
            { match[i] = 1; }

            //Now pick a match
            
        }
        for(int i = 0; i < match.Length; i++)
        {
            if (match[i] == 1) return e[i].id;
        }

        return -1;
    }
}
