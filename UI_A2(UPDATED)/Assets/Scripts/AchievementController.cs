using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AchievementController : MonoBehaviour {
	public static  bool isUnlocked;
	//public static bool achiveachive;
	public Image unlocked;
	// Use this for initialization
	void Start () {

		isUnlocked = getIsUnlocked ();
		//DontDestroyOnLoad (this);
		//achivement = false;
		//achivement = Instantiate;
	}
	
	// Update is called once per frame
	void Update () {
		if (isUnlocked == true) {
			unlocked.GetComponent<Image> ().enabled = true;
			Debug.Log ("Achivement setted to true");
		} else {
			unlocked.GetComponent<Image> ().enabled = false;
			Debug.Log ("Falseeeeee");
		}
	}

	public bool getIsUnlocked(){
		return isUnlocked;
	}

	public void setIsUnlocked(bool boolean){
		isUnlocked = boolean;
	}

	//this function is for testing only, remember to delete this kelvin
	public void onButtonPresed(){
	if (isUnlocked) {
			setIsUnlocked (false);
		} else {
			setIsUnlocked(true);
		}
		
		//if you setting this Script somewhere else or whereever you want to call it
		//then the function should be GameObject.GetComponent<AchievementController> ().setIsUnlocked (boolean);
		//boolean = set true or false according to what you want
		//GameObject is the public gameobject you referenced with in the inspecter
	}
}
