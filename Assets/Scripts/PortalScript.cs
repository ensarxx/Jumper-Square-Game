using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Player asd;
    public AudioClip clip;   
    public float volume=1;

    public DeadMenu deadMenu;

   
    

    void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(clip,transform.position,volume);
        switch (this.gameObject.name){
        
       
        case "level1_portal1":
            asd.level1_portal1_teleport();
            break;

        case "level1_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel2unlocked", 1);
            break;
        case "level2_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel3unlocked", 1);
            break;
        case "level3_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel4unlocked", 1);
            break;
        case "level4_teleport1":    
            asd.level4_teleport1();
            break;   
        case "level4_teleport2":
            asd.level4_teleport2();
            break;
        case "level4_teleport3":
            asd.level4_teleport3();
            break;
        case "level4_teleport4":
            asd.level4_teleport4();       
            break;
        case "level4_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel5unlocked", 1);
            break;
        case "level5_portal1":
            asd.level5_portal1();
            break;
        case "level5_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel6unlocked", 1);
            break;    
        case "level6_portal1":
            asd.level6_teleport1();
            break;       
        case "level6_portal2":
            asd.level6_teleport2();
            break;
        case "level6_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel7unlocked", 1);
            break;
        case "level7_portal1":
            asd.level7_teleport1(); 
            break;    
        case "level7_portal2":
            asd.level7_teleport2();
            break;
        case "level7_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel8unlocked", 1);
            break;    
        case "level8_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel9unlocked", 1);
            break; 
        case "level9_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel10unlocked", 1);
            break;   
        case "level10portal1":
            asd.level10_teleport1();
            break;
        case "level10_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel11unlocked",1);
            break;
        case "level11_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel12unlocked",1);
            break;
        case "level12_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel13unlocked",1);
            break;
        case "level13_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel14unlocked",1);
            break;    
        case "level14_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel15unlocked",1);
            break;                  
        case "level15_endportal":
            deadMenu.dead();
            PlayerPrefs.SetInt("iflevel16unlocked",1);
            break;            

        }
        
    }
}
