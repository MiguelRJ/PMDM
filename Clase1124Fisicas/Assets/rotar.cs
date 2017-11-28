using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar : MonoBehaviour {

	float g = 0;
	public Transform objetivo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			Invoke ("RotarY", 2F);
		}
		//if (Input.GetKeyDown("m")) {
			MirarAlObjetivo ();
		//}
	}

	void RotarY() {
		// Rota instantaneamente a la posicion indicada
		GetComponent<Rigidbody>().rotation = Quaternion.Euler(new Vector3(0,g++,0));
	}

	void MirarAlObjetivo() {
		// Obtener la posicion relativa de este objeto con respecto al que va a mirar
		// se consigue restando ambas posiciones
		Vector3 posicionRelativa = objetivo.position - transform.position;

		// Obtener el Quarternion para aplicar la rotacion
		Quaternion rotacion = Quaternion.LookRotation(posicionRelativa);

		// Aplicar la rotacion
		transform.rotation = rotacion;
	}
}
