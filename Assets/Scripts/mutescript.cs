using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutescript : MonoBehaviour
{
    public GameObject unmutebutton;

    public GameObject mutebutton;

    public GameObject soundplayer;

    public int issoundplaying;

    
    void Start()
    {
        issoundplaying = PlayerPrefs.GetInt("issoundplaying");
        mutebutton.SetActive(true);
        unmutebutton.SetActive(false);
    }

 
    void Update()
    {

        if (PlayerPrefs.GetInt("issoundplaying") == 1 )
        {
            soundplayer.SetActive(true);
            mutebutton.SetActive(true);
            unmutebutton.SetActive(false);
        }

        if (PlayerPrefs.GetInt("issoundplaying") == 0 )
        {
            soundplayer.SetActive(false);
            mutebutton.SetActive(false);
            unmutebutton.SetActive(true);
            
        }
    }

    public void mutesound(){
        
        PlayerPrefs.SetInt("issoundplaying", 0);
       
    }

    public void unmutesound(){
        
        PlayerPrefs.SetInt("issoundplaying", 1);
       
    }
    
}
