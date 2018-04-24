using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeUIScript : MonoBehaviour
{

    public GameObject UI;
    TimeDateController tdc;
    // Use this for initialization
    void Start()
    {
        tdc = UI.GetComponent<TimeDateController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Text>().text = tdc.GetTimeFormmated();
    }
}
