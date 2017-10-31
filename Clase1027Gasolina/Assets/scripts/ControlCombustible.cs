using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---
using UnityEngine.UI;

// Asignado al Slider
public class ControlCombustible : MonoBehaviour {

	float _incremento = 10F;
	Slider _slider;
	static public bool _hayCombustible = true; // true, hay combustible

	// Use this for initialization
	void Start () {
		_slider = GetComponent<Slider> (); // Puede lanzar excepcion, si el componente el null
	}
	
	// Update is called once per frame
	void Update () {
		// Añadir combustible
		if (Input.GetKeyDown (KeyCode.A)) {
			_slider.value += _incremento;
			_hayCombustible = true;
		}
		// Consumir combustible
		if (Input.GetKeyDown (KeyCode.Z)) {
			_slider.value -= _incremento;
		}

		if (_slider.value <= 0) {
			_hayCombustible = false;
		}
	}
}
