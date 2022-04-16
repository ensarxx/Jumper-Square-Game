using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloadscript : MonoBehaviour
{
    

    

    public void leveliyukle()
    {
        SceneManager.LoadScene(this.gameObject.name);

        
    }

    
}
