﻿using UnityEngine;
using System.Collections;

public class Knight : MonoBehaviour {

	public Vector3 force;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (force);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
