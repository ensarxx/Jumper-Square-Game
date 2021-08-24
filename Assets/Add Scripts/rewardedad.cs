using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class rewardedad : MonoBehaviour
{
    string gameId = "3839380";

    string placementId = "rewardedVideo";

    bool testMode = true;

    
    
    IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;


        
      
        
        
    }

    public void callrewardedad(){
        if (Advertisement.IsReady(placementId)) {
        Advertisement.Show(placementId);
        GameControlScript.moneyAmount += 100;
        }
        
    }
}
