using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    bool hasShownAds;

    void Start ()
    {
        Debug.Log ("Initializing ads");
        Advertisement.Initialize ("14851");
    }

    void Update()
    {
        if (!hasShownAds & Advertisement.IsReady ())
        {
            hasShownAds = true;
            Advertisement.Show ();
        }
    }
}
