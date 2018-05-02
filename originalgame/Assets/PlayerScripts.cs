using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour 
{
	public GameObject ball;
	public float power;

	Rigidbody rbball;
	Vector3 ballVec;

	Vector3 clickstart, clickend;

	// Use this for initialization
	void Start () {
		rbball = rbball.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			clickstart = Input.mousePosition;
			Debug.Log ("clickstart(" + clickstart);
		}
		if (Input.GetMouseButtonUp (0)) 
		{
			clickend = Input.mousePosition;
			Debug.Log ("clickend(" + clickend);
		}
		if(clickstart == clickend)
		{
			return;
		}
		ballVec =(clickend - clickstart);
		ballVec.z = ballVec.y;
		ballVec.y = 10;
		ballVec.Normalize();

		rbball.AddForce (ballVec * power);
		
	}
}
