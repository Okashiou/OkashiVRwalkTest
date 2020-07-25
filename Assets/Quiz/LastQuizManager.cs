using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastQuizManager : MonoBehaviour
{
    [Header("プレイヤー位置リセット")]
    [SerializeField]
    private GameObject player = null;

    [Header("クイズ")]
    [SerializeField]
    private string quiz = "Q1.What makes you feel nostalgic when you look at it?";
    [Header("選択肢")]
    //回答文面の作成
    [SerializeField]
    private string[] answers = new string[] {
        "answer1_Door",
        "answer2_Door",
        "answer3_Door",
        "answer4_Door"
    };

    //[Header("答え")]
    //[SerializeField]
    //private string answer = "countryside";
    [Header("次のシーン名")]
    [SerializeField]
    private List<string> next = new List<string> {
    "Goal1",
    "Goal2",
    "Goal3",
    "Goal4",
    };
    [Header("プレイヤーが選択した答え")]
    //JudgeScriptから当たった対象名受け取る
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
        if (selected == answers[0])
        {
            player.transform.position = Vector3.zero;
            SceneManager.LoadScene(next[0]);
        }
        if (selected == answers[1])
        {
            player.transform.position = Vector3.zero;
            SceneManager.LoadScene(next[1]);
        }
        if (selected == answers[2])
        {
            player.transform.position = Vector3.zero;
            SceneManager.LoadScene(next[2]);
        }
        if (selected == answers[3])
        {
            player.transform.position = Vector3.zero;
            SceneManager.LoadScene(next[3]);
        }

    }
}

