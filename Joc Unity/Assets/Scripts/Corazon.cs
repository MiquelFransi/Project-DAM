using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corazon : MonoBehaviour {
	public GameObject[] ob;
	float  count  = 10;

	public Transform campos;
	// Use this for initialization
	void Start () {
		ObstacleMaker ();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.right*PlayerPrefs.GetInt ("speed")*Time.deltaTime);
		GameObject cs=GameObject.Find("corazon");
		count -= Time.deltaTime;
		if (count <= 0) {
			Destroy(cs);
			count=10;
		}
	}
	void ObstacleMaker(){
		GameObject clone = (GameObject)Instantiate (ob[Random.Range(0,ob.Length)],transform.position,Quaternion.identity);
		clone.name="corazon";
		clone.AddComponent<BoxCollider2D> ();
		clone.GetComponent<BoxCollider2D> ().isTrigger = true;
		float xx=Random.Range(3,10);
		Invoke("ObstacleMaker",xx);
	}

}
