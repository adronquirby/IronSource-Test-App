using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewarded : MonoBehaviour
{
    public string appKey;

    // Start is called before the first frame update
    void Start()
    {
        IronSource.Agent.shouldTrackNetworkState(true);
        IronSourceEvents.onRewardedVideoAvailabilityChangedEvent += RewardedVideoAvailabilityChangedEvent;
        IronSourceEvents.onRewardedVideoAdClosedEvent += RewardedVideoAdClosedEvent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRewardedAd()
    {
        print("Playing rewarded ad...");
        IronSource.Agent.showRewardedVideo();
    }

    void RewardedVideoAdClosedEvent()
    {
        IronSource.Agent.init(appKey, IronSourceAdUnits.REWARDED_VIDEO);
        IronSource.Agent.shouldTrackNetworkState(true);        
    }

    void RewardedVideoAvailabilityChangedEvent(bool available)
    {
        bool rewardedVideoAvailability = available;
    }
}
