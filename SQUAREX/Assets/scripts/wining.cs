using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wining : MonoBehaviour {
	
	public GameObject menu;
	public GameObject target;
	float gap = 0.04f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x >= target.transform.position.x - gap
		    && transform.position.x < target.transform.position.x + gap
			&& transform.position.y < target.transform.position.y + gap
			&& transform.position.y >= target.transform.position.y - gap) {

			Debug.Log("win");
				menu.SetActive (true);
				int nextSceneIndex = SceneManager.GetActiveScene().buildIndex;
				string key = "level" + nextSceneIndex;
				PlayerPrefs.SetInt (key, nextSceneIndex);
				


		}
		
	}

	public void resetLevel(){
		int nextSceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (nextSceneIndex);
	}
}
