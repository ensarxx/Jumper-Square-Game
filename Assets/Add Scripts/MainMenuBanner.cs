using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class MainMenuBanner : MonoBehaviour
{
    string gameId = "3839380";

    string placementId = "mainmenu_downbanner";

    bool testMode = true;

    
    
    IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;


        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(placementId); 
        
        
        
    }

 
    

    
}
