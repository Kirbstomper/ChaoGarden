using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuScreenButton : MonoBehaviour {
    public static GameObject menu_display;
    public Button button;
	// Use this for initialization
	void Start () {
        Button btn = button.GetComponent<Button>();
       // btn.onClick.AddListener(ChangeColour);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
  public void ChangeColour()
    {
        print("hi");
    }
}
