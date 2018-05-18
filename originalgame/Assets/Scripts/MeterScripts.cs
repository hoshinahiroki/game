using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterScripts : MonoBehaviour {

	public PlayerScripts playerScripts;//PlayerScriptsを呼ぶ
	RectTransform rt;

	// Use this for initialization
	void Start () {
		//meterのRectTransformコンポーネントをキャッシュ
		rt = GetComponent<RectTransform> ();
		
	}
		
	
	// Update is called once per frame
	void Update () {
		//クリック中のうごきについて
		if (Input.GetMouseButton (0)) {
			//左端から、毎フレームWidthを20ずつ増やす、Hightは50に固定
			rt.sizeDelta = new Vector2 (rt.sizeDelta.x + 5.0f, 50.0f);
			//Widthが300を超えたら0に戻る
			if (rt.sizeDelta.x >= 300) {
				rt.sizeDelta = new Vector2 (0.0f, 50.0f);
			}
		}
		//クリックを離した時の動きについて
		if (Input.GetMouseButtonUp (0)) {
			//PlayerScriptsのPowerメソッドにmeterのWidthの５倍の値を送る
			playerScripts.SendMessage ("Power", rt.sizeDelta.x * 4 +150);
			//Widthを0に戻す
			rt.sizeDelta = new Vector2 (0.0f, 50.0f);
	}
}
	public void GetPlayerScripts(GameObject ball){
		//ボールはPlayerScriptsを取得する、PlayerScriptsを新しく定義
		playerScripts = ball.GetComponent<PlayerScripts> ();
	}

}