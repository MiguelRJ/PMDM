using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorObjeto : MonoBehaviour {

	public float velocidad = 50F; // Velocidad del desplazamineto en X, Y
	public float veloZoom = 5F; // Para hacer zoom

	// Valores para la ccion realizada
	bool derecha = false;
	bool izquierda = false;
	bool arriba = false;
	bool abajo = false;
	bool aumentar = false;
	bool disminuir = false;

	void Start () {
		
	}

	void Update () {
		if (derecha) {
			transform.Translate (Vector3.right * Time.deltaTime * velocidad);
		}
		if (izquierda) {
			transform.Translate (Vector3.left * Time.deltaTime * velocidad);
		}
		if (arriba) {
			transform.Translate (Vector3.up * Time.deltaTime * velocidad);
		}
		if (abajo) {
			transform.Translate (Vector3.down * Time.deltaTime * velocidad);
		}
		if (aumentar) {
			transform.localScale = new Vector3 (transform.localScale.x + veloZoom, 
												transform.localScale.y + veloZoom,
												transform.localScale.z + veloZoom);
		}
		if (disminuir) {
			transform.localScale = new Vector3 (transform.localScale.x - veloZoom, 
												transform.localScale.y - veloZoom,
												transform.localScale.z - veloZoom);
		}
		
	}

	//---
	// Metodos porpios publicos
	//---

	public void MoverDerecha(){
		derecha = true;
	}
	public void MoverIzquierda(){
		izquierda = true;
	}
	public void MoverArriba(){
		arriba = true;
	}
	public void MoverAbajo(){
		abajo = true;
	}
	public void AumentarEscala(){
		aumentar = true;
	}
	public void DisminuirEscala(){
		disminuir = true;
	}
	public void Detener(){
		derecha = false;
		izquierda = false;
		arriba = false;
		abajo = false;
		aumentar = false;
		disminuir = false;
	}
}
