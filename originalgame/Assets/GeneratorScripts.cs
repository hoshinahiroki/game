using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GeneratorScripts : MonoBehaviour {
	
	public GameObject BallPrefab;
	int interval = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			Invoke ("Generate", interval);
		}
	}
	void Generate(){
		Instantiate (BallPrefab, transform.position, transform.rotation);
	}
}