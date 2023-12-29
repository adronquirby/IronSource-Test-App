using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interstitial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IronSource.Agent.loadInterstitial();
        IronSourceEvents.onInterstitialAdClosedEvent += InterstitialAdClosedEvent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InterstitialAdClosedEvent()
    {
        IronSource.Agent.loadInterstitial();
    }

    public void PlayInterstitialAd()
    {
        print("Playing interstitial ad...");
        IronSource.Agent.showInterstitial();
    }
}
