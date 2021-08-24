using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopControllerScript : MonoBehaviour
{
    // Ensar DAŞ // bu script Shop sahnesinde çalışıyor butonlar tanımlanmıyor 
    // update metodu içerisinde  seçim ve satın alma değişkenleri denetlenerek
    // Button interractable değerleri ayarlanıyor ve karakter değişkenleri SelectCharacterScriptte Kullanılmak üzere set ediliyor

    public Button button_buy200dollars;
    public Button choose200dollars;

    public Button button_choose_free_character;

    public Button button_buy_character3;

    public Button button_choose_character3;

    public Button button_buycharacter4;

    public Button button_choose_character4;

    public Button button_buy_characterslime;

    public Button button_choose_characterslime;

    public Button button_buycharacter6;

    public Button button_choose_character6;

    
    public int is200dollarsbought;

    public static int karaktersecici;

    public int isfreecharacterchoosed = 1;
    public int ischaracter3bought;

    public int ischaracter4bought;

    public int ischaracterslimebought;

    public int ischaracter6bought;

    

    
   
  
    public void Start()
    {

        button_choose_character3.interactable = false;
        choose200dollars.interactable = false;
        button_choose_character4.interactable = false;
        button_choose_characterslime.interactable = false;
        button_choose_character6.interactable = false;
        is200dollarsbought = PlayerPrefs.GetInt("is200dollarsbought");
        ischaracter3bought = PlayerPrefs.GetInt("ischaracter3bought");
        ischaracter4bought = PlayerPrefs.GetInt("ischaracter4bought");
        ischaracterslimebought = PlayerPrefs.GetInt("ischaracterslimebought");
        ischaracter6bought = PlayerPrefs.GetInt("ischaracter6bought");
        karaktersecici = PlayerPrefs.GetInt("karaktersecici");// karakter1, karakter 2 gibi
        isfreecharacterchoosed = PlayerPrefs.GetInt("isfreecharacterchoosed");
        button_choose_characterslime.interactable = true;
        



    }

    
    void Update()
    {
        ////buy control başlangıç
        if (PlayerPrefs.GetInt("ischaracter3bought") == 1)
        {
            button_choose_character3.interactable = true;
            button_buy_character3.interactable = false;
        }

        if (PlayerPrefs.GetInt("ischaracter4bought") == 1)
            
        {
            button_choose_character4.interactable = true;
            button_buycharacter4.interactable = false;
        }

        if (PlayerPrefs.GetInt("ischaracterslimebought") == 1)
            
        {
            button_choose_characterslime.interactable = true;
            button_buy_characterslime.interactable = false;
        }

        
        if (PlayerPrefs.GetInt("is200dollarsbought") == 1)
        {
            choose200dollars.interactable = true;
            button_buy200dollars.interactable = false;

        }

        if (PlayerPrefs.GetInt("ischaracter6bought") == 1)
        {
            button_choose_character6.interactable = true;
            button_buycharacter6.interactable = false;
        }
        ////buy control bitiş
        
        if (PlayerPrefs.GetInt("karaktersecici") == 1 || PlayerPrefs.GetInt("karaktersecici") == 0 )
        {
            button_choose_free_character.interactable = false;
        }
        else
        {
            button_choose_free_character.interactable = true;
        }

///

        if (PlayerPrefs.GetInt("karaktersecici") == 2)
        {
            choose200dollars.interactable = false;
        }
        else
        {
            choose200dollars.interactable = true;
        }
        ///
        if (PlayerPrefs.GetInt("karaktersecici") == 3)
        {
            button_choose_character3.interactable = false;
        }
        else
        {
            button_choose_character3.interactable = true;
        }
        ///
        if (PlayerPrefs.GetInt("karaktersecici") == 4)
        {
            button_choose_character4.interactable = false;
        }
        else
        {
            button_choose_character4.interactable = true;
        }
        ///
        if (PlayerPrefs.GetInt("karaktersecici") == 5)
        {
            button_choose_characterslime.interactable = false;
        }
        else
        {
            button_choose_characterslime.interactable = true;
        }
        ////
        if (PlayerPrefs.GetInt("karaktersecici") == 6)
        {
            button_choose_character6.interactable = false;
        }
        else
        {
            button_choose_character6.interactable = true;
        }

        
    }


      public void buy200dollars(){
        if (GameControlScript.moneyAmount >= 200){
            GameControlScript.moneyAmount -= 200;
            PlayerPrefs.SetInt("is200dollarsbought",1);
        }
        

    }

    public void dolarekle(){
        GameControlScript.moneyAmount += 1000;
    }


    public void choose_free_karakter(){

        PlayerPrefs.SetInt("karaktersecici",1);

    }

    public void choose_200dollar_karakter(){

        if(PlayerPrefs.GetInt("is200dollarsbought") == 1){
            PlayerPrefs.SetInt("karaktersecici",2);
        }
    }

    public void buycharacter3(){
        if (GameControlScript.moneyAmount >= 500){
            GameControlScript.moneyAmount -= 500;
            PlayerPrefs.SetInt("ischaracter3bought",1);
            button_buy_character3.interactable = false;
        }

    }

    public void choosecharacter3(){
        if (PlayerPrefs.GetInt("ischaracter3bought") == 1)
        {
            PlayerPrefs.SetInt("karaktersecici",3);
            
        }
        
    }

    public void buycharacter4(){
        if (GameControlScript.moneyAmount >= 1000){
            GameControlScript.moneyAmount -= 1000;
            PlayerPrefs.SetInt("ischaracter4bought",1);
            button_buycharacter4.interactable = false;
        }
    }

    public void choosecharacter4(){
        if (PlayerPrefs.GetInt("ischaracter4bought") == 1)
        {
            PlayerPrefs.SetInt("karaktersecici", 4);
            
        }
        
        
    }

    public void buycharacterslime(){
        if (GameControlScript.moneyAmount >= 2000){
            GameControlScript.moneyAmount -= 2000;
            PlayerPrefs.SetInt("ischaracterslimebought",1);
            button_buy_characterslime.interactable = false;
            
        }
    }
    

    public void choosecharacterslime(){
        if(PlayerPrefs.GetInt("ischaracterslimebought") == 1)
        PlayerPrefs.SetInt("karaktersecici", 5);
        button_choose_characterslime.interactable= false;
    }

    public void buycharacter6(){
        if (GameControlScript.moneyAmount >=3500){
            GameControlScript.moneyAmount -= 3500;
            PlayerPrefs.SetInt("ischaracter6bought",1);
            button_buycharacter6.interactable = false;
            
        }
    }

    public void choosecharacter6(){
        if(PlayerPrefs.GetInt("ischaracter6bought") == 1)
        PlayerPrefs.SetInt("karaktersecici", 6);
        button_choose_character6.interactable= false;
    }
   
}
