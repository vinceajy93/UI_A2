using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menu : MonoBehaviour {

	public Text dprint;
	// Use this for initialization
	void Start () {
		dprint.text = "works beetches";
	}
	
	// Update is called once per frame
	void Update () {

	}

	void onButtonPress()
	{
		Application.LoadLevel("Battle Scene");
	}
}
