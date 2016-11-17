using UnityEngine;
using System.Collections;

public class DoorTrigger1 : MonoBehaviour {

	public GameObject Wall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider other)
	{

		if (other.gameObject.tag == "Player") {

			transform.position -= new Vector3 (0, 5, 0) * Time.deltaTime*5;
			 

		}

	}

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "Player") {

			Wall.transform.position += new Vector3 (0,500, 0);

		}

	}
}
