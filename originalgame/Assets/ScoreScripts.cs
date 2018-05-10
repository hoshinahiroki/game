using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour {

	public int score = 0;
	public Text scoreText;
	private string key = "Score";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString ();
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == ("can")) {
			score = score + 50;
		}
		if (other.gameObject.tag == ("sikiri")) {
			Debug.Log ("hit");
			PlayerPrefs.SetInt (key,score);
			PlayerPrefs.GetInt (key, 0);
			score = 0;
		
		}
		}
}
