using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwipeInput : MonoBehaviour {

	public Text debugPrint;
	private Vector3 startPosition = Vector3.zero;
	private Vector3 endPosition = Vector3.zero;

	float startTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) { //swipe beings
			startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}
		if (Input.GetMouseButtonUp (0)) { // swipe ends
			endPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}

		if (startPosition != endPosition & startPosition != Vector3.zero && endPosition != Vector3.zero)
		{
			float deltaX = endPosition.x - startPosition.x;
			float deltaY = endPosition.y - startPosition.y;
			if ((deltaX > 5.0f || deltaX < -5.0f) && (deltaY >= -1.0f || deltaY <= 1.0f)) 
			{
				if (startPosition.x < endPosition.x) 
				{ //swipe left to right
					debugPrint.text = ("swipped left to right");
				} 
				else 
				{ // swipe right to left
					debugPrint.text = ("swipped right to left");
				}
			}
		}
	}
}
