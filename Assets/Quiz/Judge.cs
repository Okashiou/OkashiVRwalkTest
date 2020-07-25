using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge : MonoBehaviour {

   
    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name); // ログを表示する
        QuizMgr.selected = collision.gameObject.name;
        LastQuizManager.selected = collision.gameObject.name;
    }

    //選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
    //public void JudgeAnswer(Collision collision)
    //{
    //    string answerText;
    //    //正解のデータをテキストでセットする
    //    switch (QuizMgr.count-1)
    //    {
    //        case 1:
    //            answerText = "countryside";
    //            break;
    //        case 2:
    //            answerText = "Edo Period";
    //            break;
    //        case 3:
    //            answerText = "countryside";
    //            break;
    //        case 4:
    //            answerText = "countryside";
    //            break;
    //        case 5:
    //            answerText = "countryside";
    //            break;
    //        case 6:
    //            answerText = "countryside";
    //            break;
    //        default:
    //            answerText = "coguntryside";
    //            break;
    //    }
    
		
		//選択したボタンのテキストラベルを取得する
		 //selectedAns = collision.gameObject.name;
		
		//if (selectedAns == answerText) {
		//	//選択したデータをグローバル変数に保存
		//	ResultMgr.SetJudgeData ("GREAT");
		//	Application.LoadLevel("Q" + QuizMgr.count);
		//} else {
		//	//選択したデータをグローバル変数に保存
		//	ResultMgr.SetJudgeData ("BAD");
			
		//}

	//}

}
