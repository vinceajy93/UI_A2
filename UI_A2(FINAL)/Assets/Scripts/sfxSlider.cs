using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sfxSlider : MonoBehaviour {
	private GameObject globalvar;

	// Use this for initialization
	void Start () {
		globalvar = GameObject.FindGameObjectWithTag ("global_var");
		this.gameObject.GetComponent<Slider> ().value = globalvar.GetComponent<GlobalVariable> ().getSFXsilderVal ();
	}

	public void onSFXValueChange(float val)
	{
		globalvar.GetComponent<GlobalVariable> ().setSFXsliderVal(val);
	}
}
