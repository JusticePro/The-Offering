using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pig : MonoBehaviour {

	public AudioSource source;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log ("Pig: Touched " + col.name);

		if (col.name.Equals("Priest")) {
			SceneManager.LoadScene ("Dead");
		}

		if (col.name.Equals("Throwing Knife")) {

			source.transform.parent = null;
			source.clip = clip;
			source.Play ();

			ScoreManager.pigsKilled++;
			Destroy (gameObject);
		}

	}

}