using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StableInformationScript : MonoBehaviour {
    Text infoBox;
    CreatureManager stable;
    public GameObject creatureManager;
	// Use this for initialization
	void Start () {
        infoBox = gameObject.GetComponent<Text>();
        stable = creatureManager.GetComponent<CreatureManager>();
	}
	
	// Update is called once per frame
	void Update () {
        infoBox.text = stable.stable[0].getMonsterInfomationReadable();
	}
}
