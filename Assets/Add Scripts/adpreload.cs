using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adpreload : MonoBehaviour
{
    watchadskiplevel watchadskiplevel;
    void Start()
    {
        watchadskiplevel.RequestRewardedVideo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
