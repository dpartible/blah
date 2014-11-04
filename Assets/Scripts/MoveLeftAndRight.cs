using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {	// ':' class derives from 'MonoBehaviour'

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Input.GetAxis("Horizontal") ==> gets default axis control (left, right, up, down, etc keys)
		//		In this case binds left and right buttons with 'Horizontal'
		transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime; // Moves objects left and right based on input
	}
}
