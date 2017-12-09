using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	//Recebe elemento text UI
	public Text txtProntos;
	
	// Update is called once per frame
	void Update () {
		txtProntos.text = PrincipalScript.pontos.ToString();
	}
}
