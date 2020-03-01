using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DebugDisplay : MonoBehaviour {

    private Text targetText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		string msg = "";
		if (SmartPhoneInput.IsConnected()) {
			msg += "Connected, ";
			//msg += "(" + SmartPhoneInput.PadX + "," + SmartPhoneInput.PadY + ")";
			//msg += "(" + SmartPhoneInput.PadGradX + "," + SmartPhoneInput.PadGradY + "," + SmartPhoneInput.PadGradZ + ")";
		} else {
			msg += "Disconnected: Please Access " + SmartPhoneController.WebUrl;
		}
        this.targetText = this.GetComponent<Text>();
       // GetComponent<GUIText>().text = msg;
         this.targetText.text = msg;
    }
}
