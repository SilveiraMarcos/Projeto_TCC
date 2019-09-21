using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorDeCigarros : MonoBehaviour {

	public AudioSource collectSound;


	public void desativarCigarro(GameObject Cigarro){
		
		Vector3 posicao = new Vector3 (Random.Range (-10 , 10 ),0,Random.Range (-10, 10 ) );
		Instantiate (Cigarro, posicao, Quaternion.identity);

		collectSound.Play ();
		SistemScore.Score ++;
		SistemScore.currentTime = 0;

		Destroy (Cigarro);
	}
}