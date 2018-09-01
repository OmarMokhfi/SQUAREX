using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class about : MonoBehaviour {

	public GameObject aboutPanel;

	public void show(){
		aboutPanel.SetActive (true);
	}

	public void hide(){
		aboutPanel.SetActive (false);
	}

}
