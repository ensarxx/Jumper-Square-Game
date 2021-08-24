using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class deadadscript : MonoBehaviour
{

    string gameId = "3839380";

    string placementId = "deadAd";

    bool testMode = true;




 IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;


        
        
        
        
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Advertisement.Show(placementId);
    }

}
