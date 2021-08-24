using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSoundScript : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip clip;
    public int volume = 1;
    

    // Update is called once per frame
    public void spikemuzikcal()
    {
        AudioSource.PlayClipAtPoint(clip,transform.position,volume);
    }
}
