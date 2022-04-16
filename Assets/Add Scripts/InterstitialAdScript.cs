using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InterstitialAdScript : MonoBehaviour
{
    private InterstitialAd interstitial;

    private void Start()
    {
        RequestInterstitial();
    }
    private void RequestInterstitial()
    {

        string adUnitId = "ca-app-pub-3253759534064842/5893312127";


        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void CallInterstitial()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
}
