using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public GameObject Audiosource;
	//public AudioClip soundClip;
	public GameObject globalvar;


	public float lowPitchRange = .95f;
	public float highPitchRange = 1.05f;


	// Use this for initialization
	void Start () {
			DontDestroyOnLoad (gameObject);

	}

	public void CreateAudioSource(AudioClip clipSound)
	{
		GameObject copy = Audiosource;
		copy.GetComponent<AudioSource> ().clip = clipSound;
		copy.GetComponent<AudioSource> ().volume = globalvar.GetComponent<GlobalVariable> ().getSFXsilderVal ();
		Instantiate (copy);
	}

	public void RandomizeSfx(params AudioClip [] clips)
	{

		//float randomPitch = Random.Range (lowPitchRange, highPitchRange);

		//efxSource.pitch = randomPitch;
		//efxSource.clip = clips (randomIndex);
		//efxSource.Play ();
	}


}
