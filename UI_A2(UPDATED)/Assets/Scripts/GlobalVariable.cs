using UnityEngine;
using System.Collections;

public class GlobalVariable : MonoBehaviour {

	private static float mainsliderVal;
	private static float SFXsliderVal;
	private static bool mainToggle;
	private static bool SFXToggle;

	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (this);

		mainsliderVal = 1.0f;
		SFXsliderVal = 1.0f;
		mainToggle = true;
		SFXToggle = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float getmainsliderVal(){
		return mainsliderVal;
	}

	public void setmainliderVal(float val){
		mainsliderVal = val;
		//Debug.Log ("mainsliderval: " + mainsliderVal);
	}

	public float getSFXsilderVal(){
		return SFXsliderVal;
	}

	public void setSFXsliderVal(float val){
		SFXsliderVal = val;
		//Debug.Log ("sfxsliderval: " + SFXsliderVal);
	}

	public bool getMainToggle(){
		return mainToggle;
	}

	public void setMainToggle(bool toggle){
		mainToggle = toggle;
	}

	public bool getSFXToggle(){
		return SFXToggle;
	}

	public void setSFXToggle(bool toggle){
		SFXToggle = toggle;
	}
}
