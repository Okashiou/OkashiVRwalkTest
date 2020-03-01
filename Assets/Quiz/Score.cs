using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Text scoreLabel = GameObject.Find("Canvas/Score").GetComponent<Text>();
		scoreLabel.color = Color.red;
		int Score = ResultMgr.GetScoreData ();
		scoreLabel.text = Score.ToString() + " 点" ;
	}
	
}
