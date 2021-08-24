using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class slimemobscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidBody;

    public float xforce = 0.01f;
    void Start()
    {
        
        Debug.Log("Start Methodu Debug");
        Time.timeScale = 1.5f;
        myRigidBody = GetComponent<Rigidbody2D>();
        
    
    }

    // Update is called once per frame
    void Update(){
        
        
            StartCoroutine(gox());
        
        
 
    }

      public IEnumerator gox(){
          yield return new WaitForSeconds(2f);
          transform.position = new Vector3(transform.position.x+xforce,transform.position.y,transform.position.z);
          yield return new WaitForSeconds(2f);
          
      }
    
 }
