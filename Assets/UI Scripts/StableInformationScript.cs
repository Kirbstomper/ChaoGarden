using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StableInformationScript : MonoBehaviour {
    Text infoBox;
    CreatureManager stable;
    public GameObject creatureManager;
    enum stable_creatures { CREATURE_1, CREATURE_2, CREATURE_3 };
    int selected;
    // Use this for initialization
    void Start () {
        infoBox = gameObject.GetComponent<Text>();
        stable = creatureManager.GetComponent<CreatureManager>();
        selected = 0;
	}
	
	// Update is called once per frame
	void Update () {
        infoBox.text = stable.stable[selected].getMonsterInfomationReadable();
	}

    public void SelectCreature(int c)
    {
        if (stable.stable[c]!= null)
        switch (c){

            case 0:
                selected = (int)stable_creatures.CREATURE_1;
                break;
            case 1:
                selected = (int)stable_creatures.CREATURE_2;
                break;
            case 2:
                selected = (int)stable_creatures.CREATURE_3;
                break;
            default:
                selected = (int)stable_creatures.CREATURE_1;
                break;
        }
    }
}
