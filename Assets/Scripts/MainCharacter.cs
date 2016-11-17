using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {

	bool isAttacking = false;
	public GameObject TPC;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W) && isAttacking == false) {
		 
			GetComponent<Animation>().Play ();
		
		}

		if (Input.GetMouseButtonDown(0) && isAttacking == false) {
			isAttacking = true;
			TPC.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().user_h = 0f; 
			TPC.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().user_v = 0f; 
			StartCoroutine (waitForAnim());

		}
	
	}

	IEnumerator waitForAnim(){
		GetComponent<Animation> ().Play ("attack_2");
		var timedelay = 1.5f;
		while (timedelay >= 0) {
			yield return null;
			timedelay -= Time.deltaTime;
		}
		isAttacking = false;
		TPC.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().user_h = 1f; 
		TPC.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().user_v = 1f; 
	}

}
