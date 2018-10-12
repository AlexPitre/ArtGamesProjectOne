using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSound : MonoBehaviour {
	//AudioSource audio;
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "food") {
			//Debug.Log ("sound");
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();

		}
	}
	}