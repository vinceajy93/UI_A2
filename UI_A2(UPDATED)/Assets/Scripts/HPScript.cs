using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HPScript : MonoBehaviour {

	public Image healthBar;
	public float health;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		checkHealth ();
	}

	void checkHealth(){
		healthBar.rectTransform.localScale = new Vector3 (health /100, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == ("enemy")) {
			subtractHealth (10.0f);
			Debug.Log("collides!");
		} else if(other.collider.CompareTag("")){
			addHealth(10.0f);
		}
	}

	public void addHealth(float amount){
		if (health + amount > 100.0f) {
			health = 100.0f;
		}else{
			health += amount;
		}
	}

	public void subtractHealth(float amount){
	if (health - amount < 0.0f) {
			health = 0.0f;
		} else {
			health -= amount;
		}
	}
}