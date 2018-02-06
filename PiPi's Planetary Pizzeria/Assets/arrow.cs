using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 targetPosition = transform.position;

        float angle = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
            angle = 5.0f;
        else if (Input.GetKey(KeyCode.RightArrow))
            angle = -5.0f;

        if ( angle != 0)
            // transfomation
            transform.Rotate(Vector3.forward, angle);

        

    }
}
