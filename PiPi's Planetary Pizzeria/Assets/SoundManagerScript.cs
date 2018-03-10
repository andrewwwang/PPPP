using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	private static AudioClip jump;
	private static AudioClip explosion;
	static AudioSource audioScr;

	// Use this for initialization
	void Awake () {
		jump = Resources.Load<AudioClip> ("Jump");
		explosion = Resources.Load<AudioClip> ("Explosion");
		audioScr = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void PlaySound (string clip){
		switch (clip) {
		case "Jump":
			audioScr.time = 1.0f;
			audioScr.PlayOneShot (jump);
			break;
		case "Explosion":
			audioScr.time = 1.0f;
			audioScr.PlayOneShot (explosion);
			break;
		}
	}
}
