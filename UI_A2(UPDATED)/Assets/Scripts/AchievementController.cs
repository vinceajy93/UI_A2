using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AchievementController : MonoBehaviour {
	private bool achivement = false;
	//public static bool achiveachive;
	public Image achive;
	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad (this);
		//achivement = false;
		//achivement = Instantiate;
	}
	
	// Update is called once per frame
	void Update () {
		if (achivement == true) {
			achive.GetComponent<Image> ().enabled = true;
			Debug.Log ("Achivement setted to true");
		} else {
			achive.GetComponent<Image> ().enabled = false;
			Debug.Log ("Falseeeeee");
		}
	}
	public void UpdateUponLeaving(){
		achivement = true;
		Debug.Log ("HIII");
	}
}
