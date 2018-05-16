using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRigidScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "start") {
			GetComponent<Rigidbody> ().isKinematic = false;
		} else if (other.gameObject.tag == "end") {
			GetComponent<Rigidbody> ().isKinematic = true;
		}

				
	}
}
