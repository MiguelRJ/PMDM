using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anadirBotones : MonoBehaviour {

	GameObject _primerBoton;		// Boton a clonar
	GameObject _padreDeLosBotones; 	// Contenido


	// Use this for initialization
	void Start () {
		_primerBoton = GameObject.Find ("btnPrimero");
		_padreDeLosBotones = GameObject.Find ("Contenido");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AnadirBoton() {
		// Anado un clon del boton "btnPrimero" como hijo del GameObject "Contenido"
		Instantiate(_primerBoton,_padreDeLosBotones.GetComponent<Transform>());
	}
}
