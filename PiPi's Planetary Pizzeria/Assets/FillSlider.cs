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
	public GameObject truck;

    public static int direction;

    private Rigidbody2D rg2d;
    private SpriteRenderer flipper;


    Vector2 targetPosition;

	// Use this for initialization
	void Awake () {
        direction = 1;
        rg2d = pizzaSlice.GetComponent<Rigidbody2D>();
        flipper = truck.GetComponent<SpriteRenderer>();

        targetPosition = transform.position;

	}

    // FixedUpdate is called once per interval
    void FixedUpdate() {
        ss.value += direction * fillSpeed;

        if (ss.value >= ss.maxValue) {
            direction = -1;
            flipper.flipX = true;

        }
        else if (ss.value <= ss.minValue) {
        	direction = 1;
        	flipper.flipX = false;
        }
	
        if ( Input.GetKeyUp(KeyCode.Space) )
        {

            // move the pizza to the nob location

            Vector2 movement = point.transform.position - pizzaSlice.transform.position;

            movement.Normalize();

            movement *= ss.value;

            rg2d.AddForce(movement);

			direction = 0;

            Arrow.gameObject.SetActive(false);
			this.gameObject.SetActive (false);

			rg2d.transform.parent = null;
				
            PiPiCode.started = true;
        }
			
        	
	}



}
