using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarLerp : MonoBehaviour {

	public Transform _desde;
	public Transform _hasta;
	public float _velocidad = 0.1F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Lerp (_desde.rotation, _hasta.rotation, Time.time * _velocidad);
		//transform.rotation = Quaternion.Euler (23,45,19);
		//transform.eulerAngles = new Vector3 (23,45,19);
		//transform.Rotate(new Vector3(2,6,6), Space.Self);

	}
}
