using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour {

	float speed = 0.05f;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (speed * 6*Time.deltaTime,0,0);
	}
}
