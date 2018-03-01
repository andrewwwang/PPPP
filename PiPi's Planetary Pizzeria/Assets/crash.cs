using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour {

	void onTriggerEnter2D (Collider2D col){
		GameControlScript.health -= 1;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
