using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotarCubo : MonoBehaviour {

	public float x=2;
	public float y=0;
	public float z=0;
	public float w=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = new Quaternion (z, y, z, w);
		//transform.rotation = Quaternion.Euler (45F, 45F, 45F);
		Debug.Log ("x->" + x.ToString());
		Debug.Log ("y->" + y.ToString());
		Debug.Log ("z->" + z.ToString());
		Debug.Log ("w->" + w.ToString());
	}
}
