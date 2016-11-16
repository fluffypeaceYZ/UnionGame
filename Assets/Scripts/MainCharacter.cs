using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) {
		 
			GetComponent<Animation>().Play ();
		
		}

		if (Input.GetMouseButtonDown) {

			GetComponent<Animation>().Play ();

		}
	
	}
}
