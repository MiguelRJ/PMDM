using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationsuave : MonoBehaviour {

	public float _velocidad = 2F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Jump") != 0) {
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (0, 90, 0), Time.deltaTime * _velocidad);
		}
		if (Input.GetAxis ("Fire1") != 0) {
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (0, -90, 0), Time.deltaTime * _velocidad);
		}
	}
}
