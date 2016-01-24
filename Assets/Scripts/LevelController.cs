using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelController : MonoBehaviour {

	public Button button;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//calling the main menu scene
	public void loadMainMenu(){
		Application.LoadLevel ("Main Menu Page");
	}

	//calling the tutorial scene
	public void loadTutorial(){
		Application.LoadLevel ("");
	}

	//calling the Options scene
	public void loadOptions(){
		Application.LoadLevel ("");
	}

	//calling the campaign scene
	public void loadCampaign(){
		Application.LoadLevel ("");
	}

	//calling the versus scene
	public void loadVersus(){
		Application.LoadLevel ("");
	}

	//calling the weapons selection scene
	public void loadWeaponSelect(){
		Application.LoadLevel ("");
	}
	//quiting the game (exit button is pressed)
	public void Exit(){
		Application.Quit ();
	}
}
