using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		Debug.Log(col.gameObject.name+ "ha sido destruido al cochar con plano");
		Destroy(col.gameObject);
	}
}
