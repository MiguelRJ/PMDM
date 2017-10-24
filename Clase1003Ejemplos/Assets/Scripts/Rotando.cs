using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotando : MonoBehaviour {

	public float _velocidadTroque = 2F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Actuar ();
	}

	void Actuar(){
		//transform.Rotate (_velocidadTroque, 1F, 1F);
		transform.Translate (Input.GetAxis ("Horizontal") * 0.1F, 0, Input.GetAxis("Vertical") * 0.1F);
		if (Input.GetAxis ("Fire1") != 0) {
			print ("Dispara");
		}
	}
}
