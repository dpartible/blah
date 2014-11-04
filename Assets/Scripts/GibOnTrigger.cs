using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour {

	// put something in place of destroyed object
	public GameObject gib;

	void OnTriggerEnter(){	// object runs into something else
		Instantiate (gib, transform.position, Quaternion.identity); // 'Quaternion.identity' ==> dont care about rotation
		Destroy (gameObject);	// destroy object this script is attached to
	}

}
