using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class musicSlider : MonoBehaviour {
	private GameObject globalvar;

	// Use this for initialization
	void Start () {
		globalvar = GameObject.FindGameObjectWithTag ("global_var");
		this.gameObject.GetComponent<Slider> ().value = globalvar.GetComponent<GlobalVariable> ().getmainsliderVal ();
	}

	public void onMainValueChange(float val)
	{
		globalvar.GetComponent<GlobalVariable> ().setmainliderVal(val);
	}
		
}
