using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour {

	void OnMouseDown(){
		
		transform.localScale *= 0.9F;
		
	}
	
	void OnMouseUp(){
		
		//GameObject.FindGameObjectWithTag("bola");
		
		if (GameObject.FindGameObjectWithTag ("quit")) {
			Application.Quit();
			
		}
		
		
	}
}
