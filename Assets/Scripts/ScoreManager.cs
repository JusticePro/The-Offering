using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text lambText;
	public Text bullText;
	public Text pigText;

	public Text candleText;
	public Text knifeText;

	public static int lambsKilled = 0;
	public static int bullsKilled = 0;
	public static int pigsKilled = 0;

	public static int candles = 0;
	public static int knives = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lambText.text = "x " + lambsKilled;
		bullText.text = "x " + bullsKilled;
		pigText.text = "x " + pigsKilled;

		candleText.text = "x " + candles;
		knifeText.text = knives + " x";
	}

}