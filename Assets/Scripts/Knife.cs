﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

	public AudioSource source;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.name.Equals("Priest")) {
			source.transform.parent = null;
			source.clip = clip;
			source.Play ();

			ScoreManager.knives += 1;
			Destroy (gameObject);
		}

	}

}