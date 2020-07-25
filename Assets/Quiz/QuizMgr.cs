﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;//UI オブジェクトを扱う時は必須
using UnityEngine.SceneManagement;

public class QuizMgr : MonoBehaviour {

    [Header("プレイヤー位置リセット")]
    [SerializeField]
    private GameObject player=null;

    static public int count = 1;
    [Header("クイズ")]
    [SerializeField]
    private string quiz = "Q1.What makes you feel nostalgic when you look at it?";
    [Header("選択肢")]
    //回答文面の作成
    [SerializeField]
    private string[] answers = new string[] {
        "countryside",
        "Old shrines and temples",
        "Painting",
        "I do not feel like that"
    };
   
    [Header("答え")]
    [SerializeField]
    private string answer = "countryside";
    [Header("次のシーン名")]
    [SerializeField]
    private string next = "Q2";
    [Header("プレイヤーが選択した答え")]
    [SerializeField]
    static public string selected = "";
    //アタッチしたオブジェクトが呼ばれた時に実行される。
    void Start()
    {
        //初期化
        selected = "";
        player = GameObject.Find("Player");

    }

    void Update()
    {

        if (selected == answer)
        {
            player.transform.position = Vector3.zero;
            SceneManager.LoadScene(next);
        }
        else
        {
           

        }
    }

	//private void QuestionLabelSet(){
	//	//特定の名前のオブジェクトを検索してアクセス
	//	Text qLabel = GameObject.Find("Question").GetComponentInChildren<Text> ();
	//	//データをセットすることで、既存情報を上書きできる
	//	qLabel.text = quiz;

 //       count = 2;
 //   }
 //   private void QuestionLabelSet2()
 //   {
 //       //特定の名前のオブジェクトを検索してアクセス
 //       Text qLabel = GameObject.Find("Question").GetComponentInChildren<Text>();
 //       //データをセットすることで、既存情報を上書きできる
 //       qLabel.text = "Q2.If you can choose, what age do you want to live?"; 
 //       count = 3;
 //   }
 //   private void  AnswerLabelSet(){
		
	//	//ボタンが4つあるのでそれぞれ代入
	//	for (int i=1; i<= answers.Length ; i++){
 //           Text ansLabel = GameObject.Find("Ans" + i).GetComponentInChildren<Text> ();
	//		ansLabel.text = answers[i-1];
	//	}
	//}
 //   private void AnswerLabelSet2()
 //   {
 //       //回答文面の作成
 //       string[] array = new string[] { "age of civil war", "Edo Period", "Ancient times","It's good to stay modern"};
 //       //ボタンが4つあるのでそれぞれ代入
 //       for (int i = 1; i <= array.Length; i++)
 //       {
 //           Text ansLabel = GameObject.Find("Ans" + i).GetComponentInChildren<Text>();
 //           ansLabel.text = array[i - 1];
 //       }
       
 //   }
 //   private void QuestionLabelSet3()
 //   {
 //       //特定の名前のオブジェクトを検索してアクセス
 //       Text qLabel = GameObject.Find("Question").GetComponentInChildren<Text>();
 //       //データをセットすることで、既存情報を上書きできる
 //       qLabel.text = "Q3.What would you like to be if you could reborn?";

 //       count = 4;
 //   }
 //   private void AnswerLabelSet3()
 //   {
 //       //回答文面の作成
 //       string[] array = new string[] { "After all human", "Other animals", "Insects", "Creatures other than Earth" };
 //       //ボタンが4つあるのでそれぞれ代入
 //       for (int i = 1; i <= array.Length; i++)
 //       {
 //           Text ansLabel = GameObject.Find("Ans" + i).GetComponentInChildren<Text>();
 //           ansLabel.text = array[i - 1];
 //       }

 //   }
}
