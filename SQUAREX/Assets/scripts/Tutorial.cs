using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

	int count;
	public GameObject tut1;
	public GameObject x1;
	public GameObject x2;
	public GameObject y1;
	public GameObject y2;
	public GameObject tut2;
	public GameObject player;
	public GameObject menu;
	Vector3 pos;

	// Use this for initialization
	void Start () {

		count = 0;
		pos = player.transform.position;
		player.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (count == 0) {

			if (Input.GetMouseButtonDown (0)) {
				tut1.SetActive (false);
				x1.SetActive (true);
				player.SetActive (true);
				count++;
			}

		} else if (count == 1) {

			if (Input.GetMouseButtonDown (0) && Input.mousePosition.y <= Screen.height / 2 && Input.mousePosition.x > Screen.width / 2) {
				x1.SetActive (false);
				x2.SetActive (true);
				count++;
			}

		}else if (count == 2) {

			if (Input.GetMouseButtonDown (0) && Input.mousePosition.y <= Screen.height / 2 && Input.mousePosition.x <= Screen.width / 2) {
				x2.SetActive (false);
				y1.SetActive (true);
				count++;
			}
			}else if (count == 3) {

			if (Input.GetMouseButtonDown (0) && Input.mousePosition.y > Screen.height / 2 && Input.mousePosition.x > Screen.width / 2) {
					y1.SetActive (false);
					y2.SetActive (true);
					count++;
			}
				}else if (count == 4) {

			if (Input.GetMouseButtonDown (0) && Input.mousePosition.y > Screen.height / 2 && Input.mousePosition.x <= Screen.width / 2) {
						y2.SetActive (false);
						tut2.SetActive (true);
						count++;
			}
					} else if (count == 5) {

			if (player.transform.position != pos) {
				PlayerPrefs.SetInt ("level2", 2);
				menu.SetActive (true);
						}

					}
		
	}
}
