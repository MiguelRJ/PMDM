using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaCast : MonoBehaviour {

	Vector3 posicionInicial;
	float radio;
	Vector3 direccionRayoEsfera;
	RaycastHit infoImpacto;
	float distancia;

	void Start () {
		radio = transform.localScale.x / 2;
		direccionRayoEsfera = Vector3.right;
		distancia = 5;
	}

	void Update () {
		// personaje = gameObject.GetComponent<CharacterController> ();
		posicionInicial = transform.position;
		if (Physics.SphereCast(posicionInicial,radio,direccionRayoEsfera,out infoImpacto,distancia,1,QueryTriggerInteraction.UseGlobal)){
			Debug.Log ("Detectado obstaculo a "+infoImpacto.distance);
		}
		Debug.DrawRay (transform.position, direccionRayoEsfera*5, Color.green);
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(posicionInicial+direccionRayoEsfera*distancia, radio);
	}

}
