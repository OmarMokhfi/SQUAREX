using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {




	public void goNextLevel(){

		int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
		SceneManager.LoadScene(nextSceneIndex);

	}

	public void goLevel(int levelId){

		SceneManager.LoadScene(levelId);

	}
		
}
