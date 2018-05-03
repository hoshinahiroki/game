using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterScripts : MonoBehaviour {

	public PlayerScripts playerScripts;
	RectTransform rt;

	// Use this for initialization
	void Start () {
		rt = GetComponent<RectTransform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			rt.sizeDelta = new Vector2 (rt.sizeDelta.x + 4.0f, 50.0f);
			if (rt.sizeDelta.x >= 300) {
				rt.sizeDelta = new Vector2 (0.0f, 50.0f);
			}
		}
		if (Input.GetMouseButton (0)) {
			playerScripts.SendMessage ("power", rt.sizeDelta.x * 2.5);
			rt.sizeDelta = new Vector2 (0.0f, 50.0f);
		}
	}
}
