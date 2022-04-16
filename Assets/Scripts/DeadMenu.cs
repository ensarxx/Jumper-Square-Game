using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
public class DeadMenu : MonoBehaviour
{
    public GameObject DeadMenuUI;

    public GameObject TransparentDeadUI;

    public GameObject pause_button;

    public GameObject sol_buton;

    public GameObject sag_buton;

    public GameObject zipla_buton;

    public GameObject player;


    public int gostermesayisirestart;

    private InterstitialAd interstitial;

    //void Start()
    //{
    //gostermesayisirestart = PlayerPrefs.GetInt("gostermesayisirestart");
    //  DeadMenuUI.SetActive(false);
    //    TransparentDeadUI.SetActive(false);

    //  }

    string gameId = "3839380";

    string placementId = "deadAd";

    bool testMode = true;

    void Start()
    {
        gostermesayisirestart = PlayerPrefs.GetInt("gostermesayisirestart");
        DeadMenuUI.SetActive(false);
        TransparentDeadUI.SetActive(false);
        gostermesayisirestart = PlayerPrefs.GetInt("gostermesayisirestart");

        RequestInterstitial();
    }

    private void RequestInterstitial()
    {

        string adUnitId = "ca-app-pub-3253759534064842/5893312127";


        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void dead(){
        player.SetActive(false);
        TransparentDeadUI.SetActive(true);
        DeadMenuUI.SetActive(true);
        pause_button.SetActive(false);
        sol_buton.SetActive(false);
        sag_buton.SetActive(false);
        zipla_buton.SetActive(false);
        Time.timeScale = 0f;

    }

    public void CallInterstitial()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }



    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gostermesayisirestart -= 1;
            PlayerPrefs.SetInt("gostermesayisirestart",gostermesayisirestart);

            if (gostermesayisirestart == -4)
            {
                CallInterstitial();
                gostermesayisirestart = 0;
                PlayerPrefs.SetInt("gostermesayisirestart", gostermesayisirestart);
            }

    }
 
}
