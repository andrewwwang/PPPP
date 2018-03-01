using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

	public GameObject Heart1;
	public GameObject Heart2;
	public GameObject Heart3;
	public GameObject gameOver;
	public static int health;

	// Use this for initialization
	void Start () {
		health = 2;
		Heart1.gameObject.SetActive (true);
		Heart2.gameObject.SetActive (true);
		Heart3.gameObject.SetActive (true);
		gameOver.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		if (health > 3)
			health = 3;

		switch (health) {
		case 3:
			Heart1.gameObject.SetActive (true);
			Heart2.gameObject.SetActive (true);
			Heart3.gameObject.SetActive (true);
			break;
		case 2:
			Heart1.gameObject.SetActive (true);
			Heart2.gameObject.SetActive (true);
			Heart3.gameObject.SetActive (false);
			break;
		case 1:
			Heart1.gameObject.SetActive (true);
			Heart2.gameObject.SetActive (false);
			Heart3.gameObject.SetActive (false);
			break;
		case 0:
			Heart1.gameObject.SetActive (false);
			Heart2.gameObject.SetActive (false);
			Heart3.gameObject.SetActive (false);
			gameOver.gameObject.SetActive (true);
			Time.timeScale = 0;
			break;

		}
	}
}
