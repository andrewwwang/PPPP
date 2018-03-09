using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PiPiCode : MonoBehaviour {


    public GameObject planet;
    public GameObject arrow;
    public GameObject slider;
    public static bool started;

    private Rigidbody2D rg2dPiPi;
    private Rigidbody2D rg2dPlanet;
    private float G;

    
	// Use this for initialization
	void Awake () {
        rg2dPiPi = this.GetComponent<Rigidbody2D>();
        rg2dPlanet = planet.GetComponent<Rigidbody2D>();

        G = (float)(rg2dPiPi.mass * rg2dPlanet.mass * 6.67 / 800);

        started = false;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (started)
        {
            // applying the force
            Vector2 gravity = rg2dPlanet.transform.position - rg2dPiPi.transform.position;
            float r = gravity.magnitude;

            gravity.Normalize();
            gravity *= G / r / r;
            rg2dPiPi.AddForce(gravity);
        }
	}
	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Mercury"))
        {
            // get PiPi's terminal velocity
            // if too fast, PiPi lose a life

            float speed = rg2dPiPi.velocity.magnitude;

            if (speed > 10)
                GameControlScript.health -= 2;
            else if (speed > 5)
                GameControlScript.health -= 1;

            // stop PiPi's movement and make the slider and arrow reappear
            rg2dPiPi.velocity = Vector2.zero;

            arrow.gameObject.SetActive(true);
            slider.gameObject.SetActive(true);

            PiPiCode.started = false;
            FillSlider.direction = 1;
        }
        else if (other.gameObject.CompareTag("Mushroom"))
        {
            // eat a mushroom
            GameControlScript.health += 1;
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Sardine"))
        {
            // eat a sardine
            GameControlScript.health += 1;
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Boundary"))
        {
            GameControlScript.health = 0;
        }

        if (GameControlScript.health == 0)
        {
            SceneManager.LoadScene(3);
        }

	}

}
