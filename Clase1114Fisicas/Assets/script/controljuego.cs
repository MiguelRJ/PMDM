using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controljuego : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision colision){
		if (colision.gameObject.tag == "Enemigo") {
			Debug.Log ("Ha colisionado con..." + colision.gameObject.name);
			//colision.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			if (colision.relativeVelocity.magnitude > 10F) {
				Destroy (colision.gameObject);
			}
		}
	}

	void OnCollisionStay(Collision colision){
		if (colision.gameObject.tag == "Enemigo") {
			Debug.Log ("Ha colisionado con..." + colision.gameObject.name);
			colision.gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
	}

	void OnCollisionExit(Collision colision){
		if (colision.gameObject.tag == "Enemigo") {
			Debug.Log ("Ha dejado de colisionar con..." + colision.gameObject.name);
			colision.gameObject.GetComponent<Renderer> ().material.color = Color.gray;
		}
	}


}
