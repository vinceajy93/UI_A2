using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AdjustVolume : MonoBehaviour {

	public Text debugPrint;
	// Use this for initialization
	void Start () {
		
	}

	/*void update(){

		bgmToggle.isOn = mainToggle_B;
		debugPrint.text = ("bgmToggle: " + bgmToggle.isOn);
	}*/

	public void updateBGMVol(float newVol){
			AudioListener.volume = newVol;
			debugPrint.text = ("vol: " +  newVol);
	}
		
	public void muteBGM(bool toggle){

		GameObject soundObject = GameObject.FindGameObjectWithTag ("mainBGM");
		AudioSource mainBGM = soundObject.GetComponent<AudioSource> ();


		if (toggle == false) {
			mainBGM.mute = true;
			debugPrint.text = ("bool: false");
		} else {
			mainBGM.mute = false;
			debugPrint.text = ("bool: true");
		}
	}
}
