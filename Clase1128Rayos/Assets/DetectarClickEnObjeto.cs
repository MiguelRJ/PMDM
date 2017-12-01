using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarClickEnObjeto : MonoBehaviour {

	Ray _pulsacion;
	RaycastHit _colision;// Almacena informacion o datos como querais

	void Start () {
			
	}

	void Update () {
		if (Input.GetMouseButton (0)) { // 0, boton izquiero del raton
			_pulsacion = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (_pulsacion, out _colision)) {
				Debug.Log (_colision.collider.name);
			}
		}
	}
}
