using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class Arvore_02 : MonoBehaviour {
	public static bool derruba = false;
	private Rigidbody corpoRigido;


	void Start () {
		corpoRigido = GetComponent<Rigidbody> ();
		corpoRigido.isKinematic = true;
		corpoRigido.useGravity = true;
	}

	void Update () {

		if (derruba == true) {
	
			corpoRigido.isKinematic = false;
			corpoRigido.AddForce (Random.Range (-30, 30), Random.Range (-5, 5), Random.Range (-30, 30));

		}
	}
}
