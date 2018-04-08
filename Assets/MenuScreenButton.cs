using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuScreenButton : MonoBehaviour {
    public static GameObject menu_display;
    public Button button;
    SpriteRenderer sr;
    // Use this for initialization
    void Start () {
        Button btn = button.GetComponent<Button>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        // btn.onClick.AddListener(ChangeColour);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    /* Button test method
     */
  public void ChangeColour(int c)
    {
        
        int s = c;
        switch (s)
        {
            case 0:
                sr.color = Color.blue;
                break;
            case 1:
                sr.color = Color.yellow;
                break;
            case 2:
                sr.color = Color.red;
                break;
            default:
                sr.color = Color.white;
                break;
        }
                   
    }
}
