using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillSlider : MonoBehaviour {

    public Slider ss;
    public int fillSpeed;
    public GameObject pizzaSlice;

    private int direction;
    private Rigidbody2D rg2d;

	// Use this for initialization
	void Start () {
        direction = 1;
        rg2d = pizzaSlice.GetComponent<Rigidbody2D>();
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



            // launch the pizza if user pressed space
            Vector2 movement = new Vector2(0, ss.value);

            rg2d.AddForce(movement);
        }
        	
	}



}
