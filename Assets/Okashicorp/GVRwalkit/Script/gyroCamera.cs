using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gyroCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    //public float minAngle = 0.0F;
    //public float maxAngle = 30.0F;
    private Text targetText;
    public float Angle = 1.0F;


    // Update is called once per frame
    void Update () {
       if( Input.acceleration.x<-0.3)
        { // float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
       // transform.eulerAngles = new Vector3(0, angle, 0);
            transform.Rotate(new Vector3(0f, -Angle, 0f));
        }
        if (Input.acceleration.x > 0.3)
        {
            //float angle = Mathf.LerpAngle(minAngle, -maxAngle, Time.time);
            //transform.eulerAngles = new Vector3(0, angle, 0);
            transform.Rotate(new Vector3(0f, Angle, 0f));
        }
        
        this.targetText = this.GetComponent<Text>(); // <---- 追加3
        //GetComponent<GUIText>().text = Input.acceleration.x.ToString("F");



    }
}
