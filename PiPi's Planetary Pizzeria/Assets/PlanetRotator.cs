using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotator : MonoBehaviour {

	private float radius;
	private float angle;

	// Use this for initialization
	void Awake () {
		// calculate radius to origin

		/*
		radius = transform.position.magnitude;
		angle = Mathf.Acos( (float)transform.position.x / radius);
		*/

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);

		/*
		angle += Mathf.PI / 360;
		transform.position = new Vector2 (radius * Mathf.Cos (angle), radius * Mathf.Sin (angle));
		*/
    }
}
