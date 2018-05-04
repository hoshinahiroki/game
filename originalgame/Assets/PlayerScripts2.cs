using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour 
{
	public GameObject ball;

	Rigidbody rbball;
	Vector3 ballVec;

	Vector3 clickstart, clickend;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		rbball = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			float distance = 100f;
			if (Physics.Raycast (ray, out hit, distance)) {
			}
			Debug.Log ("clickstart(" + clickstart);
		}
		if (Input.GetMouseButtonUp (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Debug.Log ("clickend(" + clickend);
		}
		if(clickstart == clickend)
		{
			return;
		}
		ballVec =(clickstart - clickend);
		ballVec.Normalize();
	}
	public void Power(float power){
		if (Input.GetMouseButtonUp (0)) {
			rbball.AddForce (ballVec * power);
		}

	}
}
