using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    

    public GameObject pauseMenuUI;
    

    public Player playerscript;


    
    
    public void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        

    }


    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        playerscript.basilisag = false;
        playerscript.basilisol = false;
        playerscript.basilizipla = false;
        

    }

    public void Menu(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        
    }

    public void Levels(){
        SceneManager.LoadScene("Levels");
    }
}

