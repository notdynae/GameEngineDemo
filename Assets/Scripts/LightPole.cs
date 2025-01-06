using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPole : MonoBehaviour
{
	public GameObject projectorLight;
	public void FlipLight() {
		projectorLight.SetActive(!projectorLight.activeSelf);
	}

	private void OnEnable() {
		ActionsManager.LightFlipEvent += FlipLight;
	}
	// Removes this projector as a listener for event calls on disable
	private void OnDisable() {
		ActionsManager.LightFlipEvent -= FlipLight;
	}
}
