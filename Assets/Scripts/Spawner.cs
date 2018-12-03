using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private float timer = 0;

	public float timerAmount = 1.5f;

	public bool spawnsEnemies = true;

	private float defaultAmount;

	public int candleTimerMax = 50;

	private int candleTimer = 0;

	public GameObject lamb;
	public GameObject bull;
	public GameObject pig;

	public GameObject knives;
	public GameObject candles;

	// Use this for initialization
	void Start () {
		defaultAmount = timerAmount;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer > timerAmount) {
			spawnRandom ();

			if (timerAmount<=0) {
				timerAmount = defaultAmount;
			}else {
				timerAmount -= 0.0001f;
			}

			timer = 0;
		}

	}

	void spawnRandom() {
		
		int num = Random.Range (0, (20) + 1);

		if (num == 0 || num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num == 14 || num == 17) {
			spawn (lamb);
		}

		if (num == 6 || num == 7 || num == 8 || num == 9 || num == 10 || num == 11 || num == 15 || num == 18) {

			if (spawnsEnemies) {
				spawn (pig);
			}else {
				spawn (lamb);
			}

		}

		if (num == 12) {

			if (candleTimer==candleTimerMax) {
				spawn (candles);
				candleTimer = 0;
				Debug.Log ("Spawned Candles");
			}else {
				spawn (bull);
				candleTimer++;
			}

		}

		if (num == 13 || num == 16 || num == 19 || num == 20) {
			spawn (knives);
		}

	}

	void spawn(GameObject obj) {
		GameObject instance = Instantiate (obj);

		instance.transform.position = transform.position;
	}

}