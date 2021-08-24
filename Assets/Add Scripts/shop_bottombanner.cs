using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class shop_bottombanner : MonoBehaviour
{
     string gameId = "3839380";

    string placementId = "shop_bottombanner";

    bool testMode = true;

    
    
    IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;


        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_LEFT);
        Advertisement.Banner.Show(placementId); 
        
        
        
    }

}
