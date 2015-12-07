using UnityEngine;
using System.Collections;

public class portada : MonoBehaviour {

	//public AudioClip efecto;
	AudioSource audioSource;
	private GameObject MainCamera;
	public Material colorI;
	public GameObject texto;

	void Start(){

		texto= GameObject.FindGameObjectWithTag ("titulo");

	}

	void Update(){

		//texto.gameObject = 
			//material.color;
			//title.color = new Color(1f, 0.5f, 0.8f);
		//texto.color = new Color (Random.value,Ramdom.value, 1.0f);

	}



	void OnMouseDown(){
		
		transform.localScale *= 0.9F;
		//MainCamera = GameObject.FindWithTag("MainCamera");
		//Camera.main.audio.Stop ();
		//Camera.main.GetComponent<AudioSource>()
		//MainCamera.GetComponent<AudioSource>().Stop();
		//audioSource.Stop();
		//audioSource.clip = efecto;
		//audioSource.Play();
		//GetComponent<AudioSource> ().Play ();
		//audioSource = GetComponent<AudioSource>();
		//audioSource.pitch =   4;
		//audioSource.Play ();
	}
	
	void OnMouseUp(){
		
		Application.LoadLevel("juego");
	}
}
