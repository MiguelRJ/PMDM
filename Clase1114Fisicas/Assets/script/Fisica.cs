using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour {

	public float _velocidad = 50F; // Fuerza de empuea en funion de la amsa y el rozamiento
	public Rigidbody _rigidbody;

	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		Vector3 fuerzaEmpuje = new Vector3 (
			Input.GetAxis("Horizontal") * _velocidad,
			0,
			Input.GetAxis("Vertical") * _velocidad);
		_rigidbody.AddForce (fuerzaEmpuje);
	}
}
