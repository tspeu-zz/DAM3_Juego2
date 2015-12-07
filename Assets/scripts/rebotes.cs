using UnityEngine;
using System.Collections;

public class rebotes : MonoBehaviour {

	GameObject rebote;
	private Rigidbody2D rb;
	AudioSource audio;
	
	// Use this for initialization
	void Start () {
		rebote = GameObject.FindGameObjectWithTag("rebotes");
		audio = GetComponent<AudioSource>();
	}
	
	
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag=="bola") {
			
			audio.Play();
			
		}
		if (col.gameObject.tag=="blanco") {
			
			audio.Play();
			
		}
		
		
	}
}
