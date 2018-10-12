//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

		void Update()
		{
			if (Input.GetKeyDown("x"))
			{
			SceneManager.LoadScene ("OpeningScene");
			}
		}
		
}
