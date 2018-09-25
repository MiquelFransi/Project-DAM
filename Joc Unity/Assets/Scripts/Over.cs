using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour {
	public bool over;
	public GUIStyle style2;
	public Texture image1;

	// Use this for initialization
	void Start () {
		over = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.name == "Quad1") {
			Global.vidas -= 1;  
		}else if(collider.name == "corazon") {
			GameObject cs=GameObject.Find("corazon");
		
			
			Destroy(cs);
				Global.vidas+=1;
		}
	

		if (Global.vidas == 0) {
			over = true;
			Time.timeScale = 0;
		}

	}
	void OnGUI(){
		if (over ) {
			GUI.Label (new Rect (Screen.width * 0.3f, Screen.height * 0.45f, Screen.width * 0.75f, Screen.height * 0.25f), "Game Over", style2);
			if (GUI.Button (new Rect (Screen.width * 0.48f, Screen.height * 0.55f, 50, 50),image1)){
				if (Global.high < Global.sc) {
					Global.high = Global.sc;
				}
				Global.sc = 0;
				Global.sco = 0;
				Global.escena=0;
				Global.vidas=3; 
				Time.timeScale = 1;
				Application.LoadLevel("escena1");
			}
		}
	}
}

