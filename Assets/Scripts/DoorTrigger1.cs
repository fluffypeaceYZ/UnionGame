using UnityEngine;
using System.Collections;

public class DoorTrigger1 : MonoBehaviour {

    public GameObject ThisTrigger;
    public GameObject OtherTrigger;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update() {
    }

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
            ThisTrigger.GetComponent<UpOrDown>().ThisTriggerIsUp = false;
            OtherTrigger.GetComponent<UpOrDown>().ThisTriggerIsUp = true;
        }
	}
}
