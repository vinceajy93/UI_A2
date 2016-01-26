using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class onClickSound : MonoBehaviour {

	public GameObject Audiosource;
	private GameObject globalvar;
	public AudioClip soundClip;

	// Use this for initialization
	void Start () {
		globalvar = GameObject.FindGameObjectWithTag ("global_var");
		//Audiosource = GameObject.FindGameObjectWithTag ("SoundEffects");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseDown()
	{
		GameObject copy = Audiosource;
		copy.GetComponent<AudioSource> ().clip = soundClip;
		copy.GetComponent<AudioSource> ().volume = globalvar.GetComponent<GlobalVariable> ().getSFXsilderVal ();
		Instantiate (Audiosource);
	}
}
