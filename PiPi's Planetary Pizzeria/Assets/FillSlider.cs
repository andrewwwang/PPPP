using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillSlider : MonoBehaviour {

    public Slider ss;
    public int fillSpeed;
    public GameObject pizzaSlice;
    public GameObject Arrow;
    public GameObject point;

    private int direction;
    private Rigidbody2D rg2d;

    Vector2 targetPosition;

	// Use this for initialization
	void Start () {
        direction = 1;
        rg2d = pizzaSlice.GetComponent<Rigidbody2D>();

        targetPosition = transform.position;
	}
	
	// FixedUpdate is called once per interval
	void FixedUpdate () {
        ss.value += direction * fillSpeed;

        if (ss.value >= ss.maxValue)
            direction = -1;

        else if (ss.value <= ss.minValue)
            direction = 1;
	
        if ( Input.GetKeyUp(KeyCode.Space) )
        {

            // move the pizza to the nob location

            Vector2 movement = point.transform.position;

            movement.Normalize();

            movement *= ss.value;

            rg2d.AddForce(movement);

			direction = 0;

            Arrow.gameObject.SetActive(false);

        }
			
        	
	}



}
