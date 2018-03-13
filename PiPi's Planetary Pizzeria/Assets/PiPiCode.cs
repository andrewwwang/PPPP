using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PiPiCode : MonoBehaviour {


    public GameObject planet;
    public GameObject destination;
    public GameObject arrow;
    public GameObject slider;
    public static bool started;

    private Rigidbody2D rg2dPiPi;
    private Rigidbody2D rg2dPlanet;
    private Rigidbody2D rg2dDestination;

	// Use this for initialization
	void Awake () {
        rg2dPiPi = this.GetComponent<Rigidbody2D>();
        rg2dPlanet = planet.GetComponent<Rigidbody2D>();
        rg2dDestination = destination.GetComponent<Rigidbody2D>();

        started = false;

    }
	
    void AddForce(Rigidbody2D planet)
    {
        // applying the force
        Vector2 gravity = planet.transform.position - rg2dPiPi.transform.position;
        float r = gravity.magnitude;

        gravity.Normalize();
        gravity *= (float)(rg2dPiPi.mass * planet.mass * 6.67 / 800) / r / r;
        rg2dPiPi.AddForce(gravity);

    }

	// Update is called once per frame
	void FixedUpdate () {
        if (started)
        {
            // applying the force
            AddForce(rg2dPlanet);
            AddForce(rg2dDestination);
        }
	}
	void OnTriggerEnter2D(Collider2D other)
	{
        // || other.gameObject.CompareTag("Destination") 
        if (other.gameObject.CompareTag("Mercury"))
        {
            // get PiPi's terminal velocity
            // if too fast, PiPi lose a life

            float speed = rg2dPiPi.velocity.magnitude;

			if (speed > 15) {
				SoundManagerScript.PlaySound ("Explosion");
				GameControlScript.health -= 2;
			} else if (speed > 5) {
				SoundManagerScript.PlaySound ("Explosion");
				GameControlScript.health -= 1;
			}

            // stop PiPi's movement and make the slider and arrow reappear
            rg2dPiPi.velocity = Vector2.zero;

            arrow.gameObject.SetActive(true);
            slider.gameObject.SetActive(true);

            PiPiCode.started = false;
            FillSlider.direction = 1;

			// make PiPi stick to the planet
			transform.parent = other.gameObject.transform;


        }
        else if (other.gameObject.CompareTag("Mushroom") || other.gameObject.CompareTag("Sardine") || other.gameObject.CompareTag("Olive") || other.gameObject.CompareTag("Pepperoni"))
        {
            // eat a mushroom
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

        if (other.gameObject.CompareTag("Destination"))
        {
			// save player health
			PlayerPrefs.SetInt ("Health", GameControlScript.health);

			if (PlayerPrefs.GetInt("Level") == 1) {
				PlayerPrefs.SetInt ("Level", 2);
				SceneManager.LoadScene (2);
			} else if (PlayerPrefs.GetInt("Level") == 2) {
				PlayerPrefs.SetInt ("Level", 3);
				SceneManager.LoadScene (4);
			}
        }

	}

}
