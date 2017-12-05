using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//-------------
using System.IO;

public class Interfaz : MonoBehaviour {
	
	string _texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n Aliquam in pellentesque ex. Fusce sodales, arcu nec malesuada imperdiet, felis diam tempus sapien, id porta ex elit quis justo. \n In maximus erat a tortor dapibus, sed laoreet risus mollis. \n Aliquam ullamcorper auctor velit sed lobortis. Praesent non odio at lorem iaculis auctor eu sed massa. \n Suspendisse vel velit mattis, vehicula tortor at, efficitur arcu. \n Integer ultricies sem lorem, et venenatis nunc imperdiet quis.";
	public float _velocidadScroll = 2F;
	TextMesh _componente3dText;
	Vector3 pos;
	Vector3 localVectorUp;
	public TextAsset file;
	string path = "txt.txt";

	// Use this for initialization
	void Start () {
		_componente3dText = gameObject.GetComponent<TextMesh> ();
		//_componente3dText.text = _texto;
		//_componente3dText.text = file.text;
		StreamReader st = new StreamReader(path,System.Text.Encoding.UTF8);
		_componente3dText.text = st.ReadToEnd ();
		st.Close ();
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		localVectorUp = transform.TransformDirection (0, 1, 0);
		pos += localVectorUp * _velocidadScroll * Time.deltaTime;
		transform.position = pos;
	}

	// Inmediate Mode GUI (IMGUI)
	//void OnGUI(){
		//if (GUILayout.Button ("Pulsame")) {
		//	Debug.Log ("Hola caracola");
		//}
	//}

}