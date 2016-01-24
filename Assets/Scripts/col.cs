using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class col : MonoBehaviour {

	public Text dprint;

	// Use this for initialization
	void Start () {
		dprint.text = "col script started";
	}
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D other) {
		dprint.text = "working";
		if (other.gameObject.name == "Button_B") {
			Destroy (other.gameObject);
			dprint.text = "button b destroyed";
		}
	}
}
 