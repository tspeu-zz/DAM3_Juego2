using UnityEngine;
using System.Collections;

public class bolas : MonoBehaviour {
	public int speed;
	GameObject ball;
	private Rigidbody2D rb;
	AudioSource audio;


	void Start(){
		ball = GameObject.FindGameObjectWithTag("blanco");
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity= new Vector2(speed,speed);
		audio = GetComponent<AudioSource>();

	}

	//rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,3);


	void OnMouseDown(){

		Debug.Log (ball);
		rb.AddForce(new Vector2(-5, 10), ForceMode2D.Impulse);
		speed = +5;
		rb.velocity= new Vector2(speed,speed);
		//AddForce(new Vector2(5, 5), ForceMode2D.Impulse);
		//dForce (5,5,0,ForceMode.Impulse);
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag=="bola") {

			audio.Play();
			
		}

	}

}
