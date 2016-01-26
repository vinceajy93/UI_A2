using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AdjustVolume : MonoBehaviour {

	public AudioSource soundSFX;
	public Slider mainSlider;
	public Slider SFXSlider;
	public Toggle mainToggle;
	public Toggle SFXToggle;
	public GameObject mainsoundObject;
	public GameObject sfxSoundObject;
	public GameObject globalvar;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (this);			
	}

	void Start()
	{
		globalvar = GameObject.FindGameObjectWithTag ("global_var");



		mainsoundObject = GameObject.FindGameObjectWithTag ("mainBGM");

		if (mainSlider)
			mainSlider.value = globalvar.GetComponent<GlobalVariable> ().getmainsliderVal ();

		sfxSoundObject = GameObject.FindGameObjectWithTag ("SoundEffects");

		if (SFXSlider)
			SFXSlider.value = globalvar.GetComponent<GlobalVariable> ().getSFXsilderVal ();
			
		if (mainToggle)
			mainToggle.isOn = globalvar.GetComponent<GlobalVariable> ().getMainToggle ();

		if (SFXToggle)
			SFXToggle.isOn = globalvar.GetComponent<GlobalVariable> ().getSFXToggle ();
	}

	public void updateBGMVol(float newVol){
		//AudioListener.volume = newVol;
		mainsoundObject = GameObject.FindGameObjectWithTag ("mainBGM");
		AudioSource mainBGM = mainsoundObject.GetComponent<AudioSource> ();	
		mainBGM.volume = newVol;
		globalvar.GetComponent<GlobalVariable> ().setmainliderVal (newVol);
	}

	public void updateSFXvol(float newVol){
		sfxSoundObject = GameObject.FindGameObjectWithTag ("SoundEffects");
		AudioSource soundEffects = sfxSoundObject.GetComponent<AudioSource> ();
		soundEffects.volume = newVol;
		globalvar.GetComponent<GlobalVariable> ().setSFXsliderVal (newVol);
	}
		
	public void muteBGM(bool toggle){

		GameObject soundObject = GameObject.FindGameObjectWithTag ("mainBGM");
		AudioSource mainBGM = soundObject.GetComponent<AudioSource> ();

		if (toggle == false) {
			mainBGM.mute = true;
			globalvar.GetComponent<GlobalVariable> ().setMainToggle (toggle);
			//Debug.Log ("main bgm muted");
		} else {
			mainBGM.mute = false;
			globalvar.GetComponent<GlobalVariable> ().setMainToggle (toggle);
			//Debug.Log ("main bgm unmuted");
		}
	}

	public void muteSFX(bool toggle){
		
		GameObject soundObject1 = GameObject.FindGameObjectWithTag ("SoundEffects");
		AudioSource soundEffects = soundObject1.GetComponent<AudioSource> ();

		if (toggle == false) {
			soundEffects.mute = true;
			globalvar.GetComponent<GlobalVariable> ().setSFXToggle (toggle);
			Debug.Log ("sfx bgm muted");
		} 
		else {
			soundEffects.mute = false;
			globalvar.GetComponent<GlobalVariable> ().setSFXToggle (toggle);
			Debug.Log ("sfx bgm muted");
		}

	}
}
