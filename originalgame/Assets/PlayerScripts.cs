using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour 
{
	public GameObject ball;
	Rigidbody rbball;
	Vector3 ballVec;
	public LayerMask wall;


	Vector3 click;

	// Use this for initialization
	void Start () {
		rbball = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = new Ray ();
			RaycastHit hit = new RaycastHit ();
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			//clickPosDown = Input.mousePosition;

			if (Physics.Raycast (ray, out hit, Mathf.Infinity,wall)) {
				if (hit.collider.gameObject.CompareTag ("wall")) { 
					//click = Input.mousePosition;
					click = hit.point;
					Debug.Log ("click(" + click);//flagBがないと下のifが働かない
					ballVec = (click-rbball.transform.position);
					ballVec.Normalize();
				}
			}
		}

	}
	public void Power(float power){
		if (Input.GetMouseButtonUp (0)) {
			rbball.AddForce (ballVec * power*3);
		}
		Destroy (ball, 5);
		
	}
}
