using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge : MonoBehaviour {


    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Hit"); // ログを表示する
        JudgeAnswer(collision);
    }

    //選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
    public void JudgeAnswer(Collision collision)
    {
		//正解のデータをテキストでセットする
		string answerText = "田園風景";
		//選択したボタンのテキストラベルを取得する
		TextMesh selectedBtn = collision.gameObject.GetComponentInChildren<TextMesh> ();

		if (selectedBtn.text == answerText) {
			//選択したデータをグローバル変数に保存
			ResultMgr.SetJudgeData ("正解");
			Application.LoadLevel ("Result");
		} else {
			//選択したデータをグローバル変数に保存
			ResultMgr.SetJudgeData ("不正解");
			Application.LoadLevel ("Result");
		}

	}

}
