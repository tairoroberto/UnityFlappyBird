using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class InicialScript : MonoBehaviour {

	void start() {
		FlappyBirdScript.inGame = false;
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Return) || Input.touchCount == 2){
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene("Game");
		}
	}
}
