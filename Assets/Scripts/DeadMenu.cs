using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
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

    //void Start()
   //{
        //gostermesayisirestart = PlayerPrefs.GetInt("gostermesayisirestart");
      //  DeadMenuUI.SetActive(false);
    //    TransparentDeadUI.SetActive(false);
        
  //  }

    string gameId = "3839380";

    string placementId = "deadAd";

    bool testMode = true;

    IEnumerator Start()
    {
        gostermesayisirestart = PlayerPrefs.GetInt("gostermesayisirestart");
        DeadMenuUI.SetActive(false);
        TransparentDeadUI.SetActive(false);
        gostermesayisirestart = PlayerPrefs.GetInt("gostermesayisirestart");
        Advertisement.Initialize(gameId, testMode);

        while(!Advertisement.IsReady(placementId))
        yield return null;


        
        
        
        
        
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



    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gostermesayisirestart -= 1;
            PlayerPrefs.SetInt("gostermesayisirestart",gostermesayisirestart);

            if (gostermesayisirestart == -4)
            {
                Advertisement.Show(placementId);
                gostermesayisirestart = 0;
                PlayerPrefs.SetInt("gostermesayisirestart", gostermesayisirestart);
            }

    }
 
}
