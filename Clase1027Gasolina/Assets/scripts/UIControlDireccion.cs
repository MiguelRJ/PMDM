using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControlDireccion : MonoBehaviour {

	Transform _cubo;
	public float x = 0;
	public float y = 0;
	public float z = 0;
	public float w = 0;
	public bool _sigueAlCubo = false; // Sincroniza la rotacion con el cubo

	// Use this for initialization
	void Start () {
		_cubo = GameObject.Find ("Cube").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		_cubo.transform.Rotate (Vector3.up);
		if (!_sigueAlCubo) {
			transform.rotation = new Quaternion (x, y, z, w);
		}
	}
}
