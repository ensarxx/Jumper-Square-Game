using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;



public class watchadskiplevel : MonoBehaviour
{

    

    public GameObject skiplevel_button_gameobject;

    public GameObject earncoins_button;

    public Text watchadtext;

    public string zz;

    public DeadMenu deadMenu;
    
    

    
  string gameId = "3839380";

    string placementId = "skiplevelRewardedAd";

    bool testMode = true;
    
    

    




    
    
    IEnumerator Start()
    {
        
            earncoins_button.SetActive(false);
        //string asddsa = SceneManager.GetActiveScene().ToString();
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;
        
        
        


        
        
        
        
        
    }

    
 

 
    public void skiplevel(){
        //
        Debug.Log("skiplevel !");

        deadMenu.dead();

        //
         Advertisement.Show(placementId);
         Scene currentScene = SceneManager.GetActiveScene ();
        string level = currentScene.name;
        if (level.Length == 7)
        {
            int yy = int.Parse(level[level.Length-2].ToString() + int.Parse(level[level.Length-1].ToString()));

            Debug.Log(yy);
            yy++;
            zz = "iflevel"+yy.ToString()+"unlocked";//islevel13unlocked 
            PlayerPrefs.SetInt(zz,1);
            
        }
        else{
            
       
        int xx = int.Parse(level[level.Length-1].ToString());
        xx++;
        string ff = "iflevel"+xx.ToString()+"unlocked";
        PlayerPrefs.SetInt(ff, 1);
        }
        
    }

    public void level1skiplevel(){
        
        
    }

    public void destroyskipbutton(){    
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        string level = sceneName;
        int xx = int.Parse(level[level.Length-1].ToString());
        //Debug.Log(xx);
        xx++;
        
        string ff = "iflevel"+xx.ToString()+"unlocked";//islevel3unlocked
        //Debug.Log(ff);

        if (level.Length == 7)
        {
            //int yy = int.Parse(level[level.Length-2].ToString()) + int.Parse(level[level.Length-1].ToString());
            string firstnum = level[level.Length - 2].ToString();
            string secondnum = level[level.Length - 1].ToString();

            string finalnum = firstnum + secondnum;

            int yy = int.Parse(finalnum);

            Debug.Log(yy);
            yy++;
            
            
            
            zz = "iflevel"+yy.ToString()+"unlocked";//islevel13unlocked 
        }
        
        if (PlayerPrefs.GetInt(zz) == 1)
        {
           skiplevel_button_gameobject.SetActive(false);
            earncoins_button.SetActive(true);
            watchadtext.text = "Watch Ad Earn Coins";
        }

        if (PlayerPrefs.GetInt(ff) == 1 && level.Length == 6)
        {
            //skiplevel_button.IsDestroyed = true;
            skiplevel_button_gameobject.SetActive(false);
            earncoins_button.SetActive(true);
            watchadtext.text = "Watch Ad Earn Coins";
        }

    }
}

