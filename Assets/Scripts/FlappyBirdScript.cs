using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {

	public float impulso;
	public static bool inGame;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();

		//Remove a gravidade do passaro pra evitar que ele caia antes do usuario clicar na tela
		rb.gravityScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (!inGame && Input.GetButtonDown ("Fire1")) {
			inGame = true;
			rb.gravityScale = 1.0f;
		} else if (inGame && Input.GetButtonDown ("Fire1")) {
			rb.velocity = new Vector2 (0.0f, impulso);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {

		if (collision.collider.tag != "Ceu") {
			SceneManager.LoadScene("Start");
		}

	}
}
