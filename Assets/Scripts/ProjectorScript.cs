using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class ProjectorScript : MonoBehaviour
{
    public GameObject projectorLight;
    public Material lensMaterial;
    public AudioSource projectorClick;
    public PlayableDirector timelineDirector;
    

    public byte redValue;
    public byte blueValue;
    public byte greenValue;

    public TextMeshPro rgbText;
    
    private Color _lightColor;

    public void Start()
    {
        redValue = 255;
        blueValue = 255;
        greenValue = 255;
        SetColour();
    }
   

    public void SetColour()
    {
        _lightColor = new Color(redValue / 255f, blueValue / 255f, greenValue / 255f);
        
        projectorLight.GetComponent<Light>().color = _lightColor;
        if (projectorLight.activeSelf) lensMaterial.SetColor("_EmissionColor", _lightColor);
        
        rgbText.text = $"$Red: {redValue}\n$Green: {greenValue}\n$Blue: {blueValue}";
        DynamicGI.UpdateEnvironment();
    }
	public void FlipLight() {
		projectorLight.SetActive(!projectorLight.activeSelf);
		if (!projectorLight.activeSelf) lensMaterial.SetColor("_EmissionColor", Color.black);
		projectorClick.Play();
	}

	public void PlayTimeline() {
        timelineDirector.Play();
    }

    // Sets this projector to be listening for event calls on enable
	private void OnEnable() {
		ActionsManager.LightShowEvent += PlayTimeline;
		ActionsManager.LightFlipEvent += FlipLight;
	}
    // Removes this projector as a listener for event calls on disable
	private void OnDisable() {
		ActionsManager.LightShowEvent -= PlayTimeline;
		ActionsManager.LightFlipEvent -= FlipLight;
	}
}
