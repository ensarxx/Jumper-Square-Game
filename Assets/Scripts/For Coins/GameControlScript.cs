using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour {

	public Text moneyText;
	public static int moneyAmount;

	public watchadskiplevel watchadskiplevel;
	

	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		//watchadskiplevel.destroyskipbutton();
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
		moneyText.text = "=" + moneyAmount.ToString();
		watchadskiplevel.destroyskipbutton();
	}
   
}
