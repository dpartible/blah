using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Vector3 direction = Vector3.forward; // 'forward' ==> on z axis
	public float speed = 1.0f;

	// Use this for initialization
	// Called when object is created
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// normalized speed 
		transform.position += transform.rotation * (direction.normalized * speed * Time.deltaTime);
	}
}
