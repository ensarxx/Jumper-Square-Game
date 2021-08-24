using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class SpikeScript : MonoBehaviour
{
    
    //public AudioClip clip;
    //public int volume = 1;
    public SpikeSoundScript asddsa;

    public DeadMenu deadmenuscript;
    
      void OnTriggerEnter2D(Collider2D other)
    {
         
         
        
         
         deadmenuscript.dead();
         karpuz();
         
         
        
    }

    void karpuz(){
        asddsa.spikemuzikcal();
    }
}
