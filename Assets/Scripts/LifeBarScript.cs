using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeBarScript : MonoBehaviour {
	public Sprite[] healthBarArray;
	public Image healthBar;
	public Text HealthKits;
	int NumberofKits = 0;
	private int healthBarCount = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.K)) {
		
			healthBarCount--;
			healthBar.sprite = healthBarArray [healthBarCount];
		
		}
	
	}


	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "Health")
		{
			NumberofKits+=1;
			HealthKits.text = NumberofKits.ToString();
			Destroy (other.gameObject,1);
		}
	}
}
