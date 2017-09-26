using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if( Input.GetKey( KeyCode.Space ) ) {
			rb.isKinematic = false;
	}
}
}
