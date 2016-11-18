using UnityEngine;
using System.Collections;

public class UpOrDown : MonoBehaviour {

    public bool ThisTriggerIsUp;
    float moveSpeed = 2f;
    Vector3 StartPos;
    Vector3 EndPos;

	// Use this for initialization
	void Start () {

        StartPos = new Vector3(0.0f, 0.0f, 0.0f);
        EndPos = new Vector3(0.0f, -50.0F, 0.0f);

        if (transform.position.y == 0)
        {
            ThisTriggerIsUp = true;
        }
        else
        {
            ThisTriggerIsUp = false;
        }

    }
	
	// Update is called once per frame
	void Update () {
	    if (ThisTriggerIsUp == false)
        {
            transform.position = Vector3.Lerp(transform.position, EndPos, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, StartPos, moveSpeed * Time.deltaTime);
        }
	}
}
