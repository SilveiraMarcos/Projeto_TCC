using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemScore : MonoBehaviour {

	public GameObject scoreText;
	private bool verificBtStart = false;

	public static bool ent_01 = false;
	public static bool ent_02 = false;
	public static bool ent_03 = false;
	public static bool ent_04 = false;
	public static bool ent_05 = false;

	public static bool ent_01_tree = false;
	public static bool ent_02_tree = false;
	public static bool ent_03_tree = false;

	public GameObject fireAlto;
	public GameObject fireMedio;
	public GameObject fireBaixo;
	public GameObject TextTime;

	public GameObject Info_menu;
	public GameObject Info_01;
	public GameObject Info_02;
	public GameObject Info_03;
	public GameObject Info_04;
	public GameObject Info_05;
	public GameObject Info_06;

	public GameObject SomFinal;
	public GameObject SomAnimais;
	public GameObject SomFogo;
	public GameObject soundTree;

	public GameObject cigarro;
	private bool verificCig = false;

	public static int Score = 0;

	//private float seconds = 5;
	public static float currentTime = 0;

	private bool verifL = false;


	void Update () {


		if(verificBtStart == true){

			if(verificCig == false){
				cigarro.SetActive (true);
				verificCig = true;
			}

			currentTime += Time.deltaTime;
			if (currentTime > 30.0) { // Execulta toda a parte de conclusão da cena

				if(verifL == false){
					BtComunic.verificLuz = true;
					verifL = true;
				}

				StartCoroutine (Fire ()); 
				SomFogo.SetActive (true);
				StartCoroutine (AleatorieTree());//Queda aleatória de arvores
				SomFinal.SetActive (true);
				SomAnimais.SetActive (true);
				StartCoroutine (Finaliza()); //Slidess


			}
	
			TextTime.GetComponent<Text> ().text = "TIME: " + Mathf.Floor(currentTime);  

			scoreText.GetComponent<Text>().text = "SCORE: " + Score;
		
		}

	}
	IEnumerator Finaliza(){


		if (ent_01 == false) {
			Informativo_01 ();
			ent_01 = true;
		}
		yield return new WaitForSeconds (10f);
		if (ent_02 == false) {
			Informativo_02 ();
			ent_02 = true;
		}
		yield return new WaitForSeconds (10f);
		if (ent_03 == false) {
			Informativo_03 ();
			ent_03 = true;
		}
		yield return new WaitForSeconds (10f);
		if (ent_04 == false) {
			Informativo_04 ();
				ent_04 = true;
		}
		yield return new WaitForSeconds (10f); 
		if (ent_05 == false) {
			Informativo_05 ();
			ent_05 = true;
		}
		yield return null;
	}

	IEnumerator Fire(){
		yield return new WaitForSeconds (2f); 
		fireAlto.SetActive (true);


		yield return new WaitForSeconds (5f); 
		fireMedio.SetActive (true);


		yield return new WaitForSeconds (5f);
		fireBaixo.SetActive (true);

		yield return null;

	}

	IEnumerator AleatorieTree(){
		
		yield return new WaitForSeconds (3f);
		if (ent_01_tree == false) {
			Tree_01 ();
			ent_01_tree = true;
		}
		yield return new WaitForSeconds (5f);
		if (ent_02_tree == false) {
			Tree_02 ();
			ent_02_tree = true;
		}
		yield return new WaitForSeconds (8f);
		if (ent_03_tree == false) {
			Tree_03 ();
			ent_03_tree = true;
		}

	}
	//Funçoes do menu
	public void StartBt(){
		this.verificBtStart = true;

		Info_menu.SetActive (false);
		Info_01.SetActive (true);
	}

	void Tree_01(){		
		Arvore.derruba = true;
		soundTree.SetActive (true);
	}
	void Tree_02(){
		soundTree.SetActive (false);
		Arvore_02.derruba = true;
		soundTree.SetActive (true);
	}
	void Tree_03(){
		soundTree.SetActive (false);
		Arvore_03.derruba = true;
		soundTree.SetActive (true);
	}

	//Funções de informativo


	void Informativo_01(){
		Info_01.SetActive (false);
		Info_02.SetActive (true);
	}

	void Informativo_02(){
		Info_01.SetActive (false);
		Info_02.SetActive (false);
		Info_03.SetActive (true);
	}

	void Informativo_03(){
		Info_01.SetActive (false);
		Info_02.SetActive (false);
		Info_03.SetActive (false);
		Info_04.SetActive (true);

	}

	void Informativo_04(){
		Info_01.SetActive (false);
		Info_02.SetActive (false);
		Info_03.SetActive (false);
		Info_04.SetActive (false);
		Info_05.SetActive (true);
	}

	void Informativo_05(){
		Info_01.SetActive (false);
		Info_02.SetActive (false);
		Info_03.SetActive (false);
		Info_04.SetActive (false);
		Info_05.SetActive (false);
		Info_06.SetActive (true);
	}

}