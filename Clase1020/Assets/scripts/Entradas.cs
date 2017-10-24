using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entradas : MonoBehaviour {

	public KeyCode _arriba;
	public KeyCode _abajo;
	public float _velocidad = 0.2F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Si pulso "arriba" se mueve en Y
		if (Input.GetKey (_arriba))
			transform.Translate (0, _velocidad, 0);
		if (Input.GetKey (_abajo))
			transform.Translate (0, -_velocidad, 0);
	}
}
