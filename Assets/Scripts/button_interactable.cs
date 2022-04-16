using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_interactable : MonoBehaviour
{
    public Button level2_button;
    public Button level3_button;
    public Button level4_button;
    public Button level5_button;
    public Button level6_button;
    public Button level7_button;
    public Button level8_button;
    public Button level9_button;
    public Button level10_button;
    public Button level11_button;
    public Button level12_button;
    public Button level13_button;
    public Button level14_button;
    public Button level15_button;
    public Button level16_button;







    public int iflevel2unlocked;
    public int iflevel3unclocked;
    public int iflevel4unlocked;
    public int iflevel5unlocked;
    public int iflevel6unlocked;

    public int iflevel7unlocked;

    public int iflevel8unlocked;

    public int iflevel9unlocked;

    public int iflevel10unlocked;

    public int iflevel11unlocked;

    public int iflevel12unlocked;

    public int iflevel13unlocked;

    public int iflevel14unlocked;
    

    

    void Start()
    {
        iflevel2unlocked = PlayerPrefs.GetInt("iflevel2unlocked");
        iflevel3unclocked = PlayerPrefs.GetInt("iflevel3unlocked");
        iflevel4unlocked = PlayerPrefs.GetInt("iflevel4unlocked");
        iflevel5unlocked = PlayerPrefs.GetInt("iflevel5unlocked");
        iflevel6unlocked = PlayerPrefs.GetInt("iflvel6unlocked");
        iflevel7unlocked = PlayerPrefs.GetInt("iflevel7unlocked");
        iflevel8unlocked = PlayerPrefs.GetInt("iflevel8unlocked");
        iflevel9unlocked = PlayerPrefs.GetInt("iflevel9unlocked");
        iflevel10unlocked = PlayerPrefs.GetInt("iflevel10unlocked");
        iflevel11unlocked = PlayerPrefs.GetInt("iflevel11unlocked");
        iflevel12unlocked = PlayerPrefs.GetInt("iflevel12unlocked");
        iflevel13unlocked = PlayerPrefs.GetInt("iflevel13unlocked");
        iflevel14unlocked = PlayerPrefs.GetInt("iflevel14unlocked");
        



        level2_button.interactable = false;
        level3_button.interactable = false;
        level4_button.interactable = false;
        level5_button.interactable = false;
        level6_button.interactable = false;
        level7_button.interactable = false;
        level8_button.interactable = false;
        level9_button.interactable = false;
        level10_button.interactable = false;
        level11_button.interactable = false;
        level12_button.interactable = false;
        level13_button.interactable = false;
        level14_button.interactable = false;
        level15_button.interactable = false;
        level16_button.interactable = false;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("iflevel2unlocked") ==  1)
        {
            level2_button.interactable = true;
        }        

        if (PlayerPrefs.GetInt("iflevel3unlocked") == 1)
        {
            level3_button.interactable = true;
        }

        if(PlayerPrefs.GetInt("iflevel4unlocked") == 1){
            level4_button.interactable = true;
        }

        if (PlayerPrefs.GetInt("iflevel5unlocked") == 1){
            level5_button.interactable = true;
        }

        if (PlayerPrefs.GetInt("iflevel6unlocked") == 1)
        {
            level6_button.interactable = true;
        }

        if (PlayerPrefs.GetInt("iflevel7unlocked") == 1)
        {
            level7_button.interactable = true;
        }

        if (PlayerPrefs.GetInt("iflevel8unlocked") == 1)
        {
            level8_button.interactable = true;
        }
        
        if (PlayerPrefs.GetInt("iflevel9unlocked") == 1)
        {
            level9_button.interactable = true;
        }


        if (PlayerPrefs.GetInt("iflevel10unlocked") == 1)
        {
            level10_button.interactable = true;
        }

        if (PlayerPrefs.GetInt("iflevel11unlocked") == 1)
        {
            level11_button.interactable = true;
        }

        if (PlayerPrefs.GetInt("iflevel12unlocked") == 1)
        {
            level12_button.interactable = true;
        }
        if (PlayerPrefs.GetInt("iflevel13unlocked") == 1)
        {
            level13_button.interactable = true;
        }
        if (PlayerPrefs.GetInt("iflevel14unlocked") == 1)
        {
            level14_button.interactable = true;
        }
        if (PlayerPrefs.GetInt("iflevel15unlocked") == 1)
        {
            level15_button.interactable = true;
        }
        if (PlayerPrefs.GetInt("iflevel16unlocked") == 1)
        {
            level16_button.interactable = true;
        }





    }
}
