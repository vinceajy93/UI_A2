using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//calling the main menu scene
	public void loadMainMenu(){
		SceneManager.LoadScene("Main Menu Page");
		Debug.Log ("main menu pressed");
	}

	//calling the tutorial scene
	public void loadTutorial(){
		SceneManager.LoadScene("Tutorial Page");
		Debug.Log ("tutorial pressed");
	}

	//calling the Options scene
	public void loadOptions(){
		SceneManager.LoadScene("Options Page");
		Debug.Log ("options pressed");
	}

	//calling the campaign scene
	public void loadCampaign(){
		SceneManager.LoadScene(""); //<------- need to update when scene is ready
		Debug.Log ("campaign pressed");
	}

	//calling the versus scene
	public void loadVersus(){
		SceneManager.LoadScene(""); //<------- need to update when scene is ready
		Debug.Log ("versus pressed");
	}

	//calling the weapons selection scene
	public void loadWeaponSelect(){
		SceneManager.LoadScene(""); //<------- need to update when scene is ready
		Debug.Log ("weapons selection pressed");
	}

	//calling the lose page scene
	public void loadLosePage(){
		SceneManager.LoadScene("");
		Debug.Log ("lose page");
	}

	//calling the win page scene
	public void loadWinPage(){
		SceneManager.LoadScene("");
		Debug.Log ("win page");
	}

	//calling the Achievemment page
	public void loadAchievementsPage(){
		SceneManager.LoadScene("");
		Debug.Log ("achievements page");
	}

	//calling the facebook page
	public void loadFacebookPage(){
		SceneManager.LoadScene("");
		Debug.Log ("quit pressed");
	}

	//calling the twitter page
	public void loadTwitterPage(){
		SceneManager.LoadScene("");
		Debug.Log ("quit pressed");
	}

	//quiting the game (exit button is pressed)
	public void Exit(){
		Application.Quit ();
		Debug.Log ("quit pressed");
	}
		
}
