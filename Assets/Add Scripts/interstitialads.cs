using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class interstitialads : MonoBehaviour
{
   string gameId = "3839380";

    string placementId = "interstitial";

    bool testMode = true;

    
    public int gostermesayisi;

    public int gostermesayisirestart;
    
    
    IEnumerator Start()
    {
        gostermesayisi = PlayerPrefs.GetInt("gostermesayisi");
        gostermesayisirestart = PlayerPrefs.GetInt("gostermesayisirestart");
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;


        
        
        
        
        
    }

    public void showinterstitial(){

        
        gostermesayisi -= 1;
        PlayerPrefs.SetInt("gostermesayisi", gostermesayisi);
        

        if (gostermesayisi == -2)
        {
            Advertisement.Show(placementId);
            gostermesayisi = 0;    
            PlayerPrefs.SetInt("gostermesayisi", gostermesayisi);
        }


    }


        public void showinterstitialrestart() {
            gostermesayisirestart -= 1;
            PlayerPrefs.SetInt("gostermesayisirestart",gostermesayisirestart);

            if (gostermesayisirestart == -3)
            {
                gostermesayisirestart = 0;
                PlayerPrefs.SetInt("gostermesayisirestart", gostermesayisirestart);
            }


        
    


    }

 
}
