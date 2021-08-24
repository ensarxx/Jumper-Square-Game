using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class SceneSelectScript : MonoBehaviour
{
    string gameId = "3839380";

    string placementId = "interstitial";

    bool testMode = true;

    public int gostermesayisi;



    IEnumerator Start()
    {
        PlayerPrefs.GetInt("gostermesayisi");
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;



        
        
        
        
        
    }

    

    public void selectScene(){      
        switch (this.gameObject.name){
        
        case "startbutton":
            SceneManager.LoadScene("Levels");
            gostermesayisi -=1;
            PlayerPrefs.SetInt("gostermesayisi", gostermesayisi);
            if (PlayerPrefs.GetInt("gostermesayisi") == -4)
            {
                Advertisement.Show(placementId);

            }


            break;  

        case "geributton":
            SceneManager.LoadScene("Main Menu");
            
            
            
            
            break;

        case "shopbutton":
            SceneManager.LoadScene("shop");
             
            break;
            
        }

        
    }
   
}
