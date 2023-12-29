using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeAds : MonoBehaviour
{
    public string appKey;


    private void Awake()
    {
        IronSource.Agent.init(appKey);
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadBanner();
    }

    void OnApplicationPause(bool isPaused)
    {
        IronSource.Agent.onApplicationPause(isPaused);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadBanner()
    {
        print("Loading banner...");
        IronSource.Agent.loadBanner(IronSourceBannerSize.BANNER, IronSourceBannerPosition.BOTTOM);
    }
}
