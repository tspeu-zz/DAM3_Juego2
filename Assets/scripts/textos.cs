using UnityEngine;
using System.Collections;

public class textos : MonoBehaviour {
	//GameObject menu,salir,restart;
	// Use this for initialization Application.LoadLevel (0);  
	void OnMouseDown(){
		
		transform.localScale *= 0.9F;

	}
	
	void OnMouseUp(){

		//GameObject.FindGameObjectWithTag("bola");

		if (GameObject.FindGameObjectWithTag ("menu")) {
			Application.LoadLevel(0);
			
		}



	}
}
