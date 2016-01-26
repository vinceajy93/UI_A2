using UnityEngine;
using System.Collections;

public class MoveDude : MonoBehaviour {
	private Animator mymy;
	private GameObject GO;

	// Use this for initialization
	void Start () {
		  mymy = GetComponent<Animator> ();
		  GameObject[] arrayGO = GameObject.FindGameObjectsWithTag ("myTag");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			mymy.Play ("dudeAnimUp");
			transform.Translate (new Vector3 (0, 0.01f, 0));
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			mymy.Play ("dudeAnimeDown");
			transform.Translate (new Vector3 (0, -0.01f, 0));
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			mymy.Play ("dudeAnimeLeft");
			transform.Translate (new Vector3 (-0.01f, 0, 0));
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			mymy.Play ("dudeAnimRight");
			transform.Translate (new Vector3 (0.01f, 0, 0));
		}

	
	}
}
