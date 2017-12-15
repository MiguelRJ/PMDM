using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour {

	public float _velocidad = 50F; // Fuerza de empuea en funion de la amsa y el rozamiento
	public Rigidbody _rigidbody;
	Vector3 vectical = new Vector3 (0, 1, 0.3F); // para que no caiga en vertical
	public float fuerzaTorque = 25F;

	//valor de la fuerza del salto
	public float valorSalto = 20F;
	float umbralSalto = 0.01F;

	// Sonido
	public AudioSource sonidoSalto;

	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void Update(){
		// provocar el salto de la esfera al pulsar SPACE
		if (Input.GetButtonDown ("Jump") && Mathf.Abs(_rigidbody.velocity.y) < umbralSalto) {
			_rigidbody.AddForce (vectical * valorSalto, ForceMode.Impulse);
			sonidoSalto.Play ();
		}
	}
	

	void FixedUpdate () {
		
		//aplicar fuerza de empuje
		Vector3 fuerzaEmpuje = new Vector3 (
			Input.GetAxis("Horizontal") * _velocidad,
			0,
			Input.GetAxis("Vertical") * _velocidad);
		_rigidbody.AddForce (fuerzaEmpuje);

		//aplicar fuerza de torque
		if (Input.GetKeyDown ("t")) {
			_rigidbody.AddTorque (Vector3.up * fuerzaTorque, ForceMode.Force);
		}

	}
}
