using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
		 
			GetComponent<Animation>().Play ();
		
		}

		if (Input.GetMouseButtonDown(0)) {

			GetComponent<Animation>().Play ("attack_2");

		}
	
	}
}
