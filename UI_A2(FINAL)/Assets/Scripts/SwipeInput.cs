using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwipeInput : MonoBehaviour {

	//Canvas debugObject = Canvas.FindObjectOfType ("debugtext");

	private Vector3 startPosition = Vector3.zero;
	private Vector3 endPosition = Vector3.zero;

	public static int weaponSelect = 1;
	private static bool isSwiping ;

	private int limiter = 0;

	public AudioSource audio_swipeboundary;
	public AudioSource audio_swipped;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) { //swipe beings
			startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			isSwiping = true;
		}
		if (Input.GetMouseButtonUp (0)) { // swipe ends
			endPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			isSwiping = false;
		}

		limiter++;
		if (startPosition != endPosition & startPosition != Vector3.zero && endPosition != Vector3.zero)
		{
			float deltaX = endPosition.x - startPosition.x;
			float deltaY = endPosition.y - startPosition.y;
			if ((deltaX > 2.0f || deltaX < -2.0f) && (deltaY >= -1.0f || deltaY <= 1.0f)) 
			{
				if (startPosition.x < endPosition.x && isSwiping == false) 
				{ //swipe left to right

					//debugPrint.text = ("limiter: " + limiter);
					if (limiter > 30) {
						limiter = 0;
						//audio_swipped.GetComponent<AudioSource>().Play();
						weaponSelect+=1;
					}

					if (weaponSelect > 3) {
						//audio_swipped.GetComponent<AudioSource>().Play();
						weaponSelect = 2;
					}

					isSwiping = true;
					Debug.Log ("wep: " + weaponSelect);

				} 
				else if(startPosition.x > endPosition.x && isSwiping == false)
				{ // swipe right to left

					if (limiter > 30) {
						limiter = 0;
						weaponSelect-=1;
					}

					if (weaponSelect < 1) {
						//audio_swipeboundary.GetComponent<AudioSource>().Play();
						weaponSelect = 1;
					}
					else
						//audio_swipped.GetComponent<AudioSource>().Play();
					isSwiping = true;	
					Debug.Log ("wep: " + weaponSelect);
				}
			}
		}
	}
}
