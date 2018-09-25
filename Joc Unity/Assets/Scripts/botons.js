#pragma strict
var count:float = 200000000000000;
function Start () {
}

function FixedUpdate () {
count -= Time.deltaTime;
			if (count <= 0){
				Application.LoadLevel("escena1");
			}

}
public function BotonPLAY(){
	Application.LoadLevel("escena1");
}
public function BotonPlayAgain(){
	Application.LoadLevel("escena1");
}
public function BotonInstrcciones(){
	Application.LoadLevel("escena5");
}
public function BotonMenu(){
	Application.LoadLevel("escena2");
}

public function BotonAutor(){
	Application.LoadLevel("escena6");
}
