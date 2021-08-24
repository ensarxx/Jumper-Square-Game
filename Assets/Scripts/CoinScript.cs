using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

public class CoinScript : MonoBehaviour
{


  public AudioClip clip;   
  public float volume=1;


    void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(clip,transform.position,volume);
        GameControlScript.moneyAmount += 1;
        Destroy(gameObject);

        
        
    }

}
