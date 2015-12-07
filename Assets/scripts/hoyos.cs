using UnityEngine;
using System.Collections;

public class hoyos : MonoBehaviour {
	
	//GameObject bolas;
	private Rigidbody2D rb;
	AudioSource audio;
	
	// Use this for initialization
	void Start () {
		//bolas = GameObject.FindGameObjectWithTag("bola");
		audio = GetComponent<AudioSource>();
	}
	
	// OnTriggerEnter2D OnCollisionEnter2D
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag=="bola") {
			
			audio.Play();
			Destroy(col.gameObject);
			//DestroyObject(col.gameObject);
		}
		
		/*void OnCollisionEnter2D (Collision2D col)
         {
           //Check collision name
           Debug.Log("collision name = " + col.gameObject.name);
           if(col.gameObject.name == "DeathCube")
           {
            Destroy(col.gameObject);
           }
         }*/
		
	}
}
