using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject Text;

	public void Iniciar(){
		zerandoSistemScore ();
		SceneManager.LoadScene ("CenaUnica");
	}


	void zerandoSistemScore(){
		SistemScore.ent_01 = false;
		SistemScore.ent_02 = false;
		SistemScore.ent_03 = false;
		SistemScore.ent_04 = false;
		SistemScore.ent_05 = false;

		SistemScore.ent_01_tree = false;
		SistemScore.ent_02_tree = false;
		SistemScore.ent_03_tree = false;

		SistemScore.Score = 0;

		SistemScore.currentTime = 0;

		Arvore.derruba = false;
		Arvore_02.derruba = false;
		Arvore_03.derruba = false;
	}
}
