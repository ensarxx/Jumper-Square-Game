using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public AudioClip clip;
    public int volume = 1;
    public DeadMenu deadmenuscript;
    void OnTriggerEnter2D(Collider2D other)
    {   
        AudioSource.PlayClipAtPoint(clip,transform.position,volume);
        deadmenuscript.dead();
        
        
    }
}
