using UnityEngine;
using System.Collections;

public class DestroySoundClip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!this.gameObject.GetComponent<AudioSource>().isPlaying) {
			Destroy(this.gameObject);
		} 

	}
}
