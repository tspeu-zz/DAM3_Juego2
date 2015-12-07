using UnityEngine;
using System.Collections;

public class bolasTodas : MonoBehaviour {

	GameObject bolas;
	private Rigidbody2D rb;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		bolas = GameObject.FindGameObjectWithTag("bola");
		audio = GetComponent<AudioSource>();
	}
	

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag=="bola") {
			
			audio.Play();
			
		}
		/*if (col.gameObject.tag=="hoyo") {
			
			//audio.Play();
			Destroy(bolas);
			//DestroyObject(col.gameObject);
		}*/



	}
}
