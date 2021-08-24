using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInternetConnection : MonoBehaviour
{

    public Button button_mainmenu_start;
    
    void Start()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("internet yok !");
            button_mainmenu_start.interactable = false;

        }
        else
        {
            Debug.Log("internet bağlantısı var !");
                
        }
    }

    
    void Update()
    {
        
    }
}
