using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour {

	public int score;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString ();
		
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == ("can")){
		score = score + 50;
		}
		else{
			score = score;
		}
			
	}
}
