using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.CrossPlatformInput;

public class SlimeMovement : MonoBehaviour
{
    private float speed = 0.10f;
    private int jumpforce =650;

    public Rigidbody2D myRigidBody;
    void Start()
    {
        Time.timeScale = 1.5f;
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKey(KeyCode.A)){
            transform.position = new Vector3(transform.position.x-speed,transform.position.y,transform.position.z);

        }

        if (Input.GetKey(KeyCode.D)){
            transform.position = new Vector3(transform.position.x+speed,transform.position.y,transform.position.z);

        }       
        
        
        
        if (Input.GetKeyDown(KeyCode.Space)){
            
            myRigidBody.AddForce(Vector3.up*jumpforce);
            
        }

        
    }
}
