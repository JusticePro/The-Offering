using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	public float speed = -1;
	public bool useRigidbody = false;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		if (useRigidbody) {
			rb = GetComponent<Rigidbody2D> ();
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (useRigidbody) {
			rb.velocity = new Vector2 (0, speed);
		} else {
			transform.Translate (new Vector3 (0, (speed * Time.deltaTime)));
		}

	}

}