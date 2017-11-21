using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject dinamico;
	private Vector3 _offset;

	public void Start()
	{
		_offset = transform.position - dinamico.transform.position;
	}

	public void Update()
	{
		transform.position = dinamico.transform.position + _offset;
	}
}
