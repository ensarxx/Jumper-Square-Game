using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    
    
   

    public void level1_portal1_teleport(){
        transform.position = new Vector3(transform.position.x-95,transform.position.y-80,transform.position.z);
    }

    public void level4_teleport1(){
        transform.position = new Vector3(transform.position.x+30,transform.position.y-5,transform.position.z);
    }
    
    public void level4_teleport2(){
        transform.position = new Vector3(transform.position.x+30,transform.position.y+2,transform.position.z);    

    }

    public void level4_teleport3(){
        transform.position = new Vector3(transform.position.x-3,transform.position.y+50,transform.position.z);    
    }

    public void level4_teleport4(){
        transform.position = new Vector3(transform.position.x-70,transform.position.y+10,transform.position.z);    
    }

    public void level5_portal1(){
        transform.position = new Vector3(transform.position.x+4,transform.position.y-58,transform.position.z);    
    }

    public void level6_teleport1(){
        transform.position = new Vector3(transform.position.x-36,transform.position.y-17,transform.position.z);    
    }

    public void level6_teleport2(){
        transform.position = new Vector3(transform.position.x+58,transform.position.y+10,transform.position.z);    
    }

    public void level7_teleport1(){
        transform.position = new Vector3(transform.position.x+50,transform.position.y+30,transform.position.z);    
    }

    public void level7_teleport2(){
        transform.position = new Vector3(transform.position.x,transform.position.y-68,transform.position.z);    
    }

    public void level10_teleport1(){
        transform.position = new Vector3(transform.position.x,transform.position.y-35,transform.position.z);
    }
     

    private float speed = 0.35f;
    private int jumpforce =650;

    public Rigidbody2D myRigidBody;
    
    public bool basilisag,basilisol,basilizipla;
    public int ziplamasayisi = 2;
    
    public AudioClip clip;
    public float volume = 1;
    void Start()
    {
                
        Time.timeScale = 1.5f;
        myRigidBody = GetComponent<Rigidbody2D>();
    }
public void basilitutsag(){
        basilisag = true;
    }
    public void basiliceksag(){
        basilisag = false;
    }

    public void basilitutsol(){
        basilisol = true;
    }

    public void basiliceksol(){
        basilisol = false;
    }
    public void basilitutzipla(){
        basilizipla = true;
    }

    public void basilicekzipla(){

        basilizipla = false;
    }

    void Update()
    {   

        if (Input.GetKey(KeyCode.A)){
            transform.position = new Vector3(transform.position.x-speed,transform.position.y,transform.position.z);

        }

        if (Input.GetKey(KeyCode.D)){
            transform.position = new Vector3(transform.position.x+speed,transform.position.y,transform.position.z);

        }       
        if (ziplamasayisi>0)
        {
        
        if (Input.GetKeyDown(KeyCode.Space)){
            AudioSource.PlayClipAtPoint(clip,transform.position,volume);
            myRigidBody.AddForce(Vector3.up*jumpforce);
            ziplamasayisi--;
        }

        }
        
        

        if (basilisag == true)
        {
            transform.position = new Vector3(transform.position.x+speed,transform.position.y,transform.position.z);
        }

        if (basilisol == true)

        {
            transform.position = new Vector3(transform.position.x-speed,transform.position.y,transform.position.z);
        }

        
        
       

       
    }
    
    
    
      private void OnCollisionEnter2D(Collision2D hedef){

          if (hedef.gameObject.tag == "Tilemap")
          {
              ziplamasayisi = 2;
          }
          

      }
   

        
    
          
      
      public void zipla(){

        if (ziplamasayisi >0)
        {   AudioSource.PlayClipAtPoint(clip,transform.position,volume);
            myRigidBody.AddForce(Vector3.up*jumpforce);
            ziplamasayisi--;
              
            
        }

      
      }
          
    
        
        
    }

    

