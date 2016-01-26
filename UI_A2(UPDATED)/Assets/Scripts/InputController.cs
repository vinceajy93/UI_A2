using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputController : MonoBehaviour {
	public Text printout;
	public GameObject joyFG;
	public GameObject joyBG;

	public float speed = 5.0f;
	// Use this for initialization
	void Start () {
		printout.text = "Programme Started!";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickedButtonA(){
		printout.text = "Button A clicked";
	}

	public void ClickedButtonB(){
		printout.text = "Button B clicked";
	}

	public void Dragging(){

		printout.text = "dragging: " + Input.mousePosition.x + ", " + Input.mousePosition.y;
		Vector3 newPos = new Vector3 (Input.mousePosition.x - 48, Input.mousePosition.y - 48, 1.0f);
		joyFG.GetComponent<RectTransform>().position = newPos;
		printout.text = "dragging: " + Input.mousePosition.x + ", " + Input.mousePosition.y;
		//joyFG.transform.Translate (joyFG.virtualAxes);
	}

	public void ReturnJoyFG() {
		joyFG.GetComponent<RectTransform>().position = new Vector3 ( joyBG.GetComponent<RectTransform>().position.x + 48, joyBG.GetComponent<RectTransform>().position.y + 48, 1.0f);
	}
}
