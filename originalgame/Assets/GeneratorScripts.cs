using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorScripts : MonoBehaviour {
	public GameObject BallPrefab;
	float timer = 0.0f;
	int interval = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			timer += Time.deltaTime;
			if (timer >= interval) {
				Instantiate (BallPrefab,transform.position,transform.rotation);
				timer = 0.0f;
			}
		}
	}
}