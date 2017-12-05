using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//---------
using UnityEngine.UI;

public class slider : MonoBehaviour {

	Slider _Slider;
	public GameObject objeto;

	// Use this for initialization
	void Start () {
		_Slider = GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (objeto != null) {
			objeto.GetComponent<Rigidbody> ().mass = _Slider.value;
			objeto.transform.localScale = new Vector3 (_Slider.value/25, _Slider.value/25, _Slider.value/25);

		}
	}
		
}
