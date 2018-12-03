using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIEvents : MonoBehaviour {

	public Text score;

	// Use this for initialization
	void Start () {
		score.text =
			"Lamb Sacrifices: " + ScoreManager.lambsKilled + "\n" +
			"Pigs Killed: " + ScoreManager.pigsKilled + ". (Worth 5 Points)\n" +
			"Bull Sacrifices: " + ScoreManager.bullsKilled + ". (Worth 10 Points)\n" +
			"Candles Collected: " + ScoreManager.candles + ". (Worth 500 Points)\n" +
			"Total Points: " + (ScoreManager.lambsKilled + (ScoreManager.bullsKilled * 10) + (ScoreManager.pigsKilled * 5) + (ScoreManager.candles * 500) );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void replay() {
		ScoreManager.lambsKilled = 0;
		ScoreManager.bullsKilled = 0;
		ScoreManager.pigsKilled = 0;
		ScoreManager.knives = 0;
		ScoreManager.candles = 0;

		SceneManager.LoadScene ("Game");
	}

	public void menu() {
		ScoreManager.lambsKilled = 0;
		ScoreManager.bullsKilled = 0;
		ScoreManager.pigsKilled = 0;
		ScoreManager.knives = 0;
		ScoreManager.candles = 0;

		SceneManager.LoadScene ("Menu");
	}

}