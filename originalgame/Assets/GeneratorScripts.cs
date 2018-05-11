using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GeneratorScripts : MonoBehaviour {
	public MeterScripts meterScripts;
	public GameObject BallPrefab;
	float interval = 0.1f;
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
		GameObject ball = Instantiate (BallPrefab, transform.position, transform.rotation);
		meterScripts.GetPlayerScripts (ball);
	}
}