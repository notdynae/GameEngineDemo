using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projector : MonoBehaviour
{
    public GameObject powerTrigger;
    public GameObject redUpTrigger;
    public GameObject redDownTrigger;
    public GameObject greenUpTrigger;
    public GameObject greenDownTrigger;
    public GameObject blueUpTrigger;
    public GameObject blueDownTrigger;

    public GameObject projectorLight;

    private byte _red;
    private byte _blue;
    private byte _green;

    private void OnTriggerEnter(Collider other)
    {

    }
}
