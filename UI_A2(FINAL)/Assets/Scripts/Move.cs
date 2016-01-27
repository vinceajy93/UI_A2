using UnityEngine;
using System.Collections;


public class Move : MonoBehaviour {

	public float speed;
	public float delta;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.up * Time.deltaTime);
		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		//transform.Translate (Vector3.right * speed);
		Vector3 v = startPos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}
}
