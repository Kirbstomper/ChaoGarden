using UnityEngine;
using System.Collections;

public class InventoryScreenScript : MonoBehaviour {
    public GameObject pm_obj;
    PlayerManager pm;
    GameObject zen;
	// Use this for initialization
	void Start () {
        pm = pm_obj.GetComponent<PlayerManager>();
        zen = GameObject.Find("Zenny");
	}
	
	// Update is called once per frame
	void Update () {
       zen.GetComponent<UnityEngine.UI.Text>().text = "" +pm.zenny;
	}

    

}
