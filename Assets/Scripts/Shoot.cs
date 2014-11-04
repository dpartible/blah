using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){	// if fire button is pressed
			// make an instance of bullet
			Instantiate(bullet, transform.position, transform.rotation);
		}
	}
}
