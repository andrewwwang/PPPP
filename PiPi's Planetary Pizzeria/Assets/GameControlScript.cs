using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

	public GameObject Heart1;
	public GameObject Heart2;
	public GameObject Heart3;
    public GameObject Mushroom;
	public static int health;

    private Rigidbody2D rg2dMushroom;

	// Use this for initialization
	void Awake () {
		health = 2;
		Heart1.gameObject.SetActive (true);
		Heart2.gameObject.SetActive (true);
		Heart3.gameObject.SetActive (true);

        rg2dMushroom = Mushroom.GetComponent<Rigidbody2D>();

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
			Time.timeScale = 0;
			break;

		}

        // randomly move pickup objects
        rg2dMushroom.position += new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f));

    }
}
