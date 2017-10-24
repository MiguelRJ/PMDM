using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

	public float _velocidad;
	float _valorZoom = 0.1F;
	float _tamanoZoom = 0.1F;

	// Use this for initialization
	void Start () {
		_velocidad = 0.2F;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal")*_velocidad, 0, 0);
		transform.Translate (0, 0, Input.GetAxis ("Vertical")*_velocidad);
		if (Input.GetAxis ("Fire1") != 0) {
			// Hacer algo
			Debug.Log("Disparando...");
		}

		// Control del Zoom
		_valorZoom = Input.GetAxis("Zoom");
		transform.localScale += new Vector3 (_valorZoom * _tamanoZoom, _valorZoom * _tamanoZoom, _valorZoom * _tamanoZoom);
	}
}