﻿using UnityEngine;
using System.Collections;

public class ballController : MonoBehaviour {

	public float laucherForce = 1000;
	private Rigidbody rb;
	private float moveForce = 100f;


	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetAxis ("Horizontal")>0.1f) {
			transform.Rotate (Vector3.up, moveForce * Time.deltaTime);
		}
		if (Input.GetAxis ("Horizontal")<-0.1f) {
			transform.Rotate (Vector3.up, -moveForce * Time.deltaTime);
		}
	}
	void OnMouseDown()
	{
		rb.AddForce (laucherForce * transform.forward);
	}
}



