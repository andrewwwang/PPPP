using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	private static AudioClip jump;
	private static AudioClip explosion;
    private static AudioClip eat;
	static AudioSource audioScr;

	// Use this for initialization
	void Awake () {
		jump = Resources.Load<AudioClip> ("Jump");
		explosion = Resources.Load<AudioClip> ("Explosion");
        eat = Resources.Load<AudioClip>("Eat");
		audioScr = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void PlaySound (string clip){
		switch (clip) {
		case "Jump":
            audioScr.volume = 1.0f;
			audioScr.time = 1.0f;
			audioScr.PlayOneShot (jump);
			break;
		case "Explosion":
            audioScr.volume = 1.0f;
            audioScr.time = 1.0f;
			audioScr.PlayOneShot (explosion);
			break;
        case "Eat":
            audioScr.volume = 1.0f;
            audioScr.time = 1.0f;
            audioScr.PlayOneShot(eat);
            break;
        }
	}
}
