using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Projector : MonoBehaviour
{
    public ProjectorScript projectorScript;
    
    public Collider powerTrigger;
    public Collider timelineTrigger;
    public Collider redUpTrigger;
    public Collider redDownTrigger;
    public Collider greenUpTrigger;
    public Collider greenDownTrigger;
    public Collider blueUpTrigger;
    public Collider blueDownTrigger;

    private void OnTriggerStay(Collider other)
    {
        if (other == redUpTrigger) projectorScript.redValue++;
        if (other == redDownTrigger) projectorScript.redValue--;
        if (other == blueUpTrigger) projectorScript.blueValue++;
        if (other == blueDownTrigger) projectorScript.blueValue--;
        if (other == greenUpTrigger) projectorScript.greenValue++;
        if (other == greenDownTrigger) projectorScript.greenValue--;
        
        projectorScript.SetColour();
    }

	private void OnTriggerEnter(Collider other) {
		// Calls different events based on the trigger that was entered
		if (other == powerTrigger) {
			ActionsManager.LightFlipEvent?.Invoke();
		}
		else if (other == timelineTrigger) {
			ActionsManager.LightShowEvent?.Invoke();
		}
	}
}
