using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class levelloadscript : MonoBehaviour
{
    string gameId = "3839380";

    string placementId = "interstitial";

    bool testMode = true;

    IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;


        
        
        
        
        
    }

    public void leveliyukle()
    {
        SceneManager.LoadScene(this.gameObject.name);

        switch (this.gameObject.name){
        
        case "level2":
            Advertisement.Show(placementId);         
            break;      
        case "level4":
            Advertisement.Show(placementId);
            break;  
        }
    }

    
}
