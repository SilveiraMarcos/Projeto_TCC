using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaPlayer : MonoBehaviour {

	public AudioSource SoundWalk;

	private bool pFrente = false;
	private bool pTras = false;
	private bool pDireita = false;
	private bool pEsquerda = false;

	
	// Update is called once per frame
	void Update () {
		float time = Time.deltaTime;

		if(pFrente){
			transform.position = new Vector3 (transform.position.x,
				transform.position.y, transform.position.z + time);
			
		}else if(pTras){
			transform.position = new Vector3 (transform.position.x,
				transform.position.y, transform.position.z - time);	
			
		}else if(pDireita){	
			transform.position = new Vector3 (transform.position.x + time,
				transform.position.y, transform.position.z);
			
		}else if(pEsquerda){
			transform.position = new Vector3 (transform.position.x - time,
				transform.position.y, transform.position.z );
			
		}
	}

	public void p_Frente(){
		pFrente = true;
		pTras = false;
		pDireita = false;
		pEsquerda = false;
		SoundWalk.Play ();
	}
	public void p_Tras(){
		pFrente = false;
		pTras = true;
		pDireita = false;
		pEsquerda = false;
		SoundWalk.Play ();
	}
	public void p_Direita(){
		pFrente = false;
		pTras = false;
		pDireita = true;
		pEsquerda = false;
		SoundWalk.Play ();
	}
	public void p_Esquerda(){
		pFrente = false;
		pTras = false;
		pDireita = false;
		pEsquerda = true;
		SoundWalk.Play ();
	}
	public void parar(){
		pFrente = false;
		pTras = false;
		pDireita = false;
		pEsquerda = false;
		SoundWalk.Pause ();
	}

}
