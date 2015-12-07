using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {

	void OnMouseDown(){
		
		transform.localScale *= 0.9F;
		
	}
	
	void OnMouseUp(){
		
		//GameObject.FindGameObjectWithTag("bola");
		if (GameObject.FindGameObjectWithTag ("restart")) {
			Application.LoadLevel(1);
			
		}
		
	}
}
