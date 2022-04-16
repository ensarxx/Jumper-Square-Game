using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInternetConnection : MonoBehaviour
{

    public Button button_mainmenu_start;
    public GameObject connection_text;
    void Start()
    {

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("internet yok !");
            button_mainmenu_start.interactable = false;
            connection_text.SetActive(true);

        }
        else
        {
            Debug.Log("internet bağlantısı var !");
            connection_text.SetActive(false);
                
        }
    }

    
    void Update()
    {
        
    }
}
