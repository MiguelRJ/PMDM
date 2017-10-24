using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour {

	public int _limMenor = -10;
	public int _limMayor = 10;
	public float _velocidad = 1F;
	int _valor = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.right;
		//transform.position = transform.right * destino;
		//transform.position = Vector3.right * destino;
		//transform.position = new Vector3(1,0,0) * destino;
		//transform.forward;

		//Mover el objeto dentro de los limites
		_valor += (int)(Input.GetAxis("Horizontal") * _velocidad);
		_valor = Mathf.Clamp (_valor,_limMenor, _limMayor);
		transform.position = new Vector3 (_valor, 0, 0);
	}
}
