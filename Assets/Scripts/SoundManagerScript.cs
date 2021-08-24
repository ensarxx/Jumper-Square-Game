using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip coinSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("coinSound");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(){
        audioSrc.PlayOneShot(coinSound);
    }
}
