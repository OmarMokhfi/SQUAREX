using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levels : MonoBehaviour {

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt ("level1", 1);
		
		Button[] allChildren = GetComponentsInChildren<Button>();
		foreach (Button child in allChildren) {
			string name = "level" + child.GetComponentInChildren<Text> ().text;
			if (!PlayerPrefs.HasKey (name)) {
				child.interactable = false;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
