using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTimeController : MonoBehaviour
{
    [Header("問題")]
    [SerializeField]
    private GameObject quiz;
    [Header("答え")]
    [SerializeField]
    private GameObject[] Ans;
    [Header("表示時間")]
    [SerializeField]
    private float settime = 10f;

    // Start is called before the first frame update
    void Start()
    {
       
        for (int i = 0; i < Ans.Length; i++)
        {
            Ans[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (settime < Time.time)
        {
            quiz.SetActive(false);
            for (int i = 0; i < Ans.Length; i++)
            {
                Ans[i].SetActive(true);
            }
        }
    }
}
