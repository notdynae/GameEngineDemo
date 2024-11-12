using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projector : MonoBehaviour
{
    public ProjectorScript projectorScript;
    
    public GameObject powerTrigger;
    public GameObject redUpTrigger;
    public GameObject redDownTrigger;
    public GameObject greenUpTrigger;
    public GameObject greenDownTrigger;
    public GameObject blueUpTrigger;
    public GameObject blueDownTrigger;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other == powerTrigger.GetComponent<Collider>()) {
            projectorScript.FlipLight();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other == redUpTrigger.GetComponent<Collider>()) projectorScript.redValue++;
        if (other == redDownTrigger.GetComponent<Collider>()) projectorScript.redValue--;
        if (other == blueUpTrigger.GetComponent<Collider>()) projectorScript.blueValue++;
        if (other == blueDownTrigger.GetComponent<Collider>()) projectorScript.blueValue--;
        if (other == greenUpTrigger.GetComponent<Collider>()) projectorScript.greenValue++;
        if (other == greenDownTrigger.GetComponent<Collider>()) projectorScript.greenValue--;
        
        projectorScript.SetColour();
    }
}
