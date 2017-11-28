using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzarrayo : MonoBehaviour {
	// Detecta un objeto delante de la trayectoria del rayo
	Vector3 fwd;
	int alcanceRayo = 100;

	void Start () {
		
	}


	void Update () {
		// fwd -> transform.TransformDirection
		fwd = transform.TransformDirection(Vector3.right * (-1) * alcanceRayo);
		if (Physics.Raycast(transform.position, fwd)) {
			Debug.Log ("Detectado");
		}
		Debug.DrawRay (transform.position, fwd, Color.green);
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.down);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up);
		}
	}
}
