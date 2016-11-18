using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeBarScript : MonoBehaviour {
	public Sprite[] healthBarArray;
	public Image healthBar;
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
}
