﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class internetcheck : MonoBehaviour
{


    void Start()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Error. Check internet connection!");
        }
        else
        {
            Debug.Log("internet is reachable");
        }
    }

}
