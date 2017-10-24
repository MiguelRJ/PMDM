using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entradas2 : MonoBehaviour {

	float esperar = 0F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Basados en el Inputmanager
		if (Input.GetButton ("Jump"))
			Debug.Log ("Jump");
		if (Input.GetButtonDown ("Fire1"))
			Debug.Log ("Down");
		
		// De tipo string tecla
		if (Input.GetKey ("a"))
			Debug.Log ("a");

		if (Input.GetKey (KeyCode.D) && Time.time > esperar) {
			Debug.Log ("d");
			esperar = Time.time + 2F; // 2 segundos
		}

		// De tipo int
		if (Input.GetMouseButtonDown (0))
			Debug.Log ("boton izquierdo raton");
		if (Input.GetMouseButtonDown (1))
			Debug.Log ("boton derecho raton");
		if (Input.GetMouseButtonDown (2))
			Debug.Log ("boton central raton");
	}
}
