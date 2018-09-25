using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour {
	public GUIStyle style1;
	//public GameObject[] ob;

	// Use this for initialization
	void Start () {
		Global.sc = 0;
		//PlayerPrefs.SetInt ("high", 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * PlayerPrefs.GetInt ("speed") * Time.deltaTime);
		Global.sco += Time.deltaTime * 10;
		Global.sc = (int)Global.sco;
		if ( Global.sc == 360 && Global.escena==0 ) {
			Application.LoadLevel("escena3");
			Global.escena=1;


		}
		if (Global.sc == 500) {
			Global.sc = 0;
			Global.sco = 0;
			Global.escena=0;
			Global.vidas=3;
			Application.LoadLevel ("escena4");


		}
	}
		void OnGUI(){

			string hi = Global.high.ToString ();
			string score = Global.sc.ToString ();
		string vidasE = Global.vidas.ToString ();

		GUI.Label (new Rect(Screen.width*0.8f,Screen.height*0.07f,Screen.width*0.2f,Screen.height*0.05f),score,style1);
		GUI.Label (new Rect(Screen.width*0.65f,Screen.height*0.07f,Screen.width*0.2f,Screen.height*0.05f),"HI "+hi,style1);
		GUI.Label (new Rect(Screen.width*0.40f,Screen.height*0.07f,Screen.width*0.2f,Screen.height*0.05f),"Vidas "+vidasE,style1);

		}

}
