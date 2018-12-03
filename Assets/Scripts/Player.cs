using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float minimumX = -1.5F;
	public float maximumX = 2.5F;

	public GameObject throwingKnife;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
			moveLeft ();
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			throwKnife ();
		}

		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
			moveRight ();
		}

	}

	public void throwKnife() {
		
		if (ScoreManager.knives > 0) {
			GameObject obj = Instantiate (throwingKnife);
			obj.name = "Throwing Knife";
			obj.transform.position = new Vector3(transform.position.x, transform.position.y + 1, -1);
			ScoreManager.knives--;
		}

	}

	public void moveLeft() {
		
		if (transform.position.x > minimumX) {
			transform.Translate (new Vector3 (-1, 0));
		}

	}

	public void moveRight() {

		if (transform.position.x < maximumX) {
			transform.Translate (new Vector3 (1, 0));
		}

	}

}