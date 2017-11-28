using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzarrayovariosobjetos : MonoBehaviour {
	// Detecta un objeto delante de la trayectoria del rayo
	Vector3 direccionRayo;
	int alcanceRayo = 200;
	RaycastHit[] objetosDetectados;

	void Start () {
		
	}


	void Update () {
		direccionRayo = transform.TransformDirection (Vector3.right * (-1) * alcanceRayo);
		objetosDetectados = Physics.RaycastAll (transform.position, direccionRayo);
		foreach (RaycastHit tmp in objetosDetectados) {
			Debug.Log ("Detectado => tipo: "+tmp.GetType().ToString() + " Distancia: "+tmp.distance.ToString() + " Collider: " +tmp.collider.ToString() );
		}
		Debug.DrawRay (transform.position, direccionRayo, Color.green);
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.down);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up);
		}
	}
}
