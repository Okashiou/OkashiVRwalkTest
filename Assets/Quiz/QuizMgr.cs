using UnityEngine;
using System.Collections;
using UnityEngine.UI;//UI オブジェクトを扱う時は必須

public class QuizMgr : MonoBehaviour {

    int count = 1;
    //アタッチしたオブジェクトが呼ばれた時に実行される。
    void Start()
    {
        if (count == 2)
        {
            QuestionLabelSet2();
            AnswerLabelSet2();
        }
        if (count == 1)
        {
            QuestionLabelSet();
            AnswerLabelSet();
        }
        
    }
	
	private void QuestionLabelSet(){
		//特定の名前のオブジェクトを検索してアクセス
		Text qLabel = GameObject.Find("Question").GetComponentInChildren<Text> ();
		//データをセットすることで、既存情報を上書きできる
		qLabel.text = "Q1.あなたがふと懐かしい感情に捕らわれるのは、次の何を見たときでしょうか？";

        count = 2;
    }
    private void QuestionLabelSet2()
    {
        //特定の名前のオブジェクトを検索してアクセス
        Text qLabel = GameObject.Find("Question").GetComponentInChildren<Text>();
        //データをセットすることで、既存情報を上書きできる
        qLabel.text = "Q2.hogegoeg？";
    }
    private void  AnswerLabelSet(){
		//回答文面の作成
		string[] array = new string[]{ "田園風景", "古い神社や仏閣", "絵画"};
		//ボタンが4つあるのでそれぞれ代入
		for (int i=1; i<=3 ; i++){
            TextMesh ansLabel = GameObject.Find("Ans" + i).GetComponentInChildren<TextMesh> ();
			ansLabel.text = array[i-1];
		}
	}
    private void AnswerLabelSet2()
    {
        //回答文面の作成
        string[] array = new string[] { "hoge", "dww", "d" };
        //ボタンが4つあるのでそれぞれ代入
        for (int i = 1; i <= 3; i++)
        {
            TextMesh ansLabel = GameObject.Find("Ans" + i).GetComponentInChildren<TextMesh>();
            ansLabel.text = array[i - 1];
        }
    }

}
