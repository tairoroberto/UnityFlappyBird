using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour {

	public float velocidade;
	public float alturaInicial, alturaFinal;
	public float limitX;

	
	// Update is called once per frame
	void Update () {

		if(FlappyBirdScript.inGame){
			//Move o cano
			transform.Translate (Vector2.left * velocidade * Time.deltaTime);

			//Verifica o limite e retorna o cano
			if(transform.position.x <= limitX) {
				transform.position = new Vector2 (limitX * -1, Random.Range(alturaInicial, alturaFinal));
			}
		}
	}


	//Detecta colisão com trigger
	public void OnTriggerEnter2D(Collider2D collider) {
		PrincipalScript.pontos++;

		print (PrincipalScript.pontos);
	}


}
