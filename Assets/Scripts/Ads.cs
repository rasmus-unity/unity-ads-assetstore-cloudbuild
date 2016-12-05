using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ads : MonoBehaviour
{
    void Start ()
    {
        Debug.Log ("Calling our fake Advertisement.Initialize() method");
        UnityEngine.Advertisements.Advertisement.Initialize ("14851");
    }
}
