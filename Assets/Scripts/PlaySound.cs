using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
public AudioClip clip;

public int volume = 1;

public void buttonsound(){
    AudioSource.PlayClipAtPoint(clip,transform.position,volume);
}


}
