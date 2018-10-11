﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMoreFood : MonoBehaviour {

	public bool stay = true;
	public Transform Spawnpoint;
	public GameObject Food;
	private float stayCount = 0.0f;
	// Use this for initialization
	void OnTriggerStay () {

		if (stay)
		{
			if (stayCount > 0.35f)
			{
				Instantiate (Food, Spawnpoint.position, Spawnpoint.rotation);
				stayCount = stayCount - 0.35f;
			}
			else
			{
				stayCount = stayCount + Time.deltaTime;
			}
		}

	}
}
