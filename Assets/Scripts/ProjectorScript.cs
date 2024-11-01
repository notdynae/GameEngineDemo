using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorScript : MonoBehaviour
{
    
    public GameObject projectorLight;

    public byte redValue;
    public byte blueValue;
    public byte greenValue;

    public void FlipLight()
    {
        projectorLight.SetActive(!projectorLight.activeSelf);
    }

    public void SetColour()
    {
        projectorLight.GetComponent<Light>().color = new Color(redValue / 255f, blueValue / 255f, greenValue / 255f);
    }
}
