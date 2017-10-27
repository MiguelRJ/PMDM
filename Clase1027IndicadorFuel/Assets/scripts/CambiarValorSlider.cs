using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//------------
using UnityEngine.UI;

public class CambiarValorSlider : MonoBehaviour {

	int valor = 0;
	public GameObject miSlider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			miSlider.GetComponent<Slider> ().value = valor++;
		}
	}
}
