using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	public static int qCount;

	public void  NextScene(){
	
		if (Application.loadedLevelName == "Title") {
			Application.LoadLevel ("Q1");
		
		}
	}

	public void NextQuiz(){
	
		if (Application.loadedLevelName == "Result") {
			 
			if(qCount < 2){
				qCount++;
				//Application.LoadLevel ("Quiz");
                Application.LoadLevel("SampleScene");
            }
            else{
				qCount = 0;
				Application.LoadLevel ("Score");
			}
		}
	}

	public void  BackToTitle(){
		
		if (Application.loadedLevelName == "Score") {
			ResultMgr.SetScoreData(0);
			Application.LoadLevel ("Title"); 
		}
	}

}
