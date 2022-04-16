using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using GoogleMobileAds.Api;



public class watchadskiplevel : MonoBehaviour
{

    

    public GameObject skiplevel_button_gameobject;

    public GameObject earncoins_button;

    public Text watchadtext;

    public string zz;

    public DeadMenu deadMenu;
    
    public rewardedad rewardedad;


    //ad
    private RewardedAd rewardedAd;


    private string rewardedAd_ID;
    //

    void Start()
    {
        earncoins_button.SetActive(false);
        skiplevel_button_gameobject.SetActive(true);

        rewardedAd_ID = "ca-app-pub-3253759534064842/1632888510";
        Debug.Log("burası çalışıyor *watchadskiplevel start fonksiyonu*");
        MobileAds.Initialize(initStatus => { });


        RequestRewardedVideo();
    }



    public void RequestRewardedVideo()
    {
        rewardedAd = new RewardedAd(rewardedAd_ID);
        //rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        //rewardedAd.OnAdClosed += HandleRewardedAdClosed;
        //rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }

    public void skiplevel(){
        
        Debug.Log("skiplevel !");

        



        //rewardedad.callrewardedad();
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
            deadMenu.dead();
            ///////////////////////////////////////////////////
            Scene currentScene = SceneManager.GetActiveScene();
            string level = currentScene.name;
            Debug.Log(level);
            if (level.Length == 7)
            {
                int yy = int.Parse(level[level.Length - 2].ToString() + int.Parse(level[level.Length - 1].ToString()));

                Debug.Log(yy);
                yy++;
                zz = "iflevel" + yy.ToString() + "unlocked";//islevel13unlocked 
                Debug.Log("BURADAYIM");
                PlayerPrefs.SetInt(zz, 1);

            }
            else
            {


                int xx = int.Parse(level[level.Length - 1].ToString());
                xx++;
                string ff = "iflevel" + xx.ToString() + "unlocked";
                Debug.Log(ff.ToString());
                PlayerPrefs.SetInt(ff, 1);
            }

            ///////////////////////////////////////////////////
        }
        
        
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
            //Debug.Log("zz ="+zz+"" );
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

