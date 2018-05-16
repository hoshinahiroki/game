using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScripts : MonoBehaviour {

	public int point = 0;
	public int Bestint;
	public int scoresum;
	public Text Scorelabel;
	public Text pointText;
	public Text Scoresum;
	public Text Bestscore;
	public GameObject scorelabel;
	public GameObject BestScore;
	public GameObject ScoreSum;
	public GameObject restart;
	public GameObject all;
	public GameObject stage3;
	public GameObject floor;
	public GameObject Point;
	public GameObject Cube;
	public GameObject bar;
	public GameObject meter;
	private string key = "Best";




	// Use this for initialization
	void Start (){
		scoresum = 0;
		Bestint = PlayerPrefs.GetInt (key, 0);
	}
	
	// Update is called once per frame
	void Update () {
		pointText.text = point.ToString ();
		Scoresum.text = "合計スコア:" + scoresum.ToString();
		Bestscore.text = "ベストスコア:" + Bestint;

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == ("can")) {
			point += 50;

		}
		if (other.gameObject.tag == ("sikiri")) {
			Debug.Log ("hit");
			scoresum += point;
			point = 0;
			Debug.Log (scoresum);
		}
		if (other.gameObject.tag == ("last")) {
			restart.SetActive (true);
			scorelabel.SetActive (true);
			ScoreSum.SetActive (true);
			BestScore.SetActive (true);
			all.SetActive (false);
			stage3.SetActive (false);
			floor.SetActive (false);
			Point.SetActive (false);
			Cube.SetActive (false);
			bar.SetActive (false);
			meter.SetActive (false);
			if (scoresum >= Bestint) {
				Scorelabel.text = "ベストスコア更新!!";
				Bestint = scoresum;
				PlayerPrefs.SetInt (key, Bestint);
			} else {
				Scorelabel.text = "残念...";
			}
		}
	}
		
}