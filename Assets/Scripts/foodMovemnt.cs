﻿using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class foodMovemnt: MonoBehaviour
{
	Transform player;
	//PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	UnityEngine.AI.NavMeshAgent nav;


	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();

		GetComponent<NavMeshAgent>().speed = Random.Range(0.1f, 5.0f);	
	}


	void Update ()
	{
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//{

		nav.SetDestination (player.position);

			

		//}
		//else
		//{
		//    nav.enabled = false;
		//}
	}
}