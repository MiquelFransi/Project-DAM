#pragma strict
var jumpHeight=5;
var spped = 5;
	var   dino:Transform;



function Start () {
PlayerPrefs.SetInt("speed",spped);	
}

function Update () {
transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);
if(Input.GetKeyDown(KeyCode.Space) && dino.position.y < 0) {
	GetComponent.<Rigidbody2D>().velocity.y=jumpHeight;
}
}

