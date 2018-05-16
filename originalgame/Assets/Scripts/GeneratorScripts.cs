using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GeneratorScripts : MonoBehaviour {
	public MeterScripts meterScripts;
	public GameObject BallPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//クリックを離したら
		if (Input.GetMouseButtonUp (0)) {
			//ジェネレーターメソッドを0.5秒毎に呼び出す
			Invoke ("Generate", 0.5f);
		}
	}
	//ジェネレーターメソッドを作る
	void Generate(){
		//BallPrefabを生成、生成したものはballと定義
		GameObject ball = Instantiate (BallPrefab, transform.position, transform.rotation);
		//meterScriptsのGetPlayerScriptsメソッドを呼ぶ
		meterScripts.GetPlayerScripts (ball);
	}
}