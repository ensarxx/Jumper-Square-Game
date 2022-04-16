using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class rewardedad : MonoBehaviour
{



    
    private RewardedAd rewardedAd;

    
    private string rewardedAd_ID;

    void Start()
    {
        
        rewardedAd_ID = "ca-app-pub-3253759534064842/1632888510";

        MobileAds.Initialize(initStatus => { });

        
        RequestRewardedVideo();

    }

    private void RequestRewardedVideo()
    {
        rewardedAd = new RewardedAd(rewardedAd_ID);
        //rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        //rewardedAd.OnAdClosed += HandleRewardedAdClosed;
        //rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }



    
    public void callrewardedad(){
       
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
            GameControlScript.moneyAmount += 100;
        }

    }
}
