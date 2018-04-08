using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuScreenButton : MonoBehaviour {
    public static GameObject menu_display;
    public Button button;
    SpriteRenderer sr;
    GameObject active;
    enum screens { INVENTORY, STABLE, MAP, SETTINGS };
    GameObject[] screenArr;
    // Use this for initialization
    void Start() {
        Button btn = button.GetComponent<Button>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        active = GameObject.Find("StableScreen");
        // btn.onClick.AddListener(ChangeColour
        screenArr = new GameObject[] { GameObject.Find("InventoryScreen"), GameObject.Find("StableScreen"), GameObject.Find("MapScreen") };

        foreach (GameObject g in screenArr)
        {
            g.active = false;
        }
            
    }

    // Update is called once per frame
    void Update() {

    }
    /* Button test method
     */
    public void ChangeColour(int c)
    {
        active.active = false;
        int s = c;
        switch (s)
        {
            case 0:
                sr.color = Color.blue;
                active = screenArr[0];
                active.active = true;
                
                break;
            case 1:
                active = screenArr[1];
                active.active = true;
                sr.color = Color.yellow;
                break;
            case 2:
                active = screenArr[2];
                active.active = true;
                sr.color = Color.red;
                break;
            default:
                sr.color = Color.white;
                break;
        }

    }


    public void ChangeScreen(int c)
    {

        int s = c;
        switch (s)
        {
            case (int)screens.INVENTORY:
                sr.color = Color.blue;
                break;
            case (int)screens.MAP:
                sr.color = Color.yellow;
                break;
            case (int)screens.STABLE:
                sr.color = Color.red;
                break;
            case (int)screens.SETTINGS:
                sr.color = Color.red;
                break;
            default:
                sr.color = Color.white;
                break;
        }

    }
    /* When called removes all things currently on the UI
     * Useful when changing screens
     */
    void CleanScreen()
    {

    }



    /* Shows the Stable screen with monster stats */
    void ShowMap() {
    }

    /* Shows the map so you can travel to shops/training screen*/
    void ShowStable() {
    }

    // Shows the settings screen with save button or return to main menu;
    void ShowSettings() {

    }

    void ShowInventory()
    {

    }
}