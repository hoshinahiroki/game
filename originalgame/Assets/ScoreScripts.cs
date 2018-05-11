using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour {

	public int score = 0;
	public Text scoreText;
	private string key = "Score";
	public GameObject last;
	public Text lastscore;
	int lastint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString ();
		lastscore.text = "合計スコア:" + lastint.ToString();
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == ("can")) {
			score = score + 50;

		}
		if (other.gameObject.tag == ("sikiri")) {
			Debug.Log ("hit");
			int scoresum = PlayerPrefs.GetInt (key, 0);
			PlayerPrefs.SetInt (key, score + scoresum);
			score = 0;
			Debug.Log (PlayerPrefs.GetInt (key, 0));
		}
		if (other.gameObject.tag == ("last")) {
			lastint = PlayerPrefs.GetInt (key, 0);
			last.SetActive (true);

			
		}
	}
}
