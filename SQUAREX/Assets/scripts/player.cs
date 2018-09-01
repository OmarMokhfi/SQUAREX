using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	float distance;
	bool dragging;
	public bool canMove = true;
	float val = 0.02f;

	void OnMouseDown()
	{
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		dragging = true;
	}

	void OnMouseUp()
	{
		dragging = false;
		canMove = false;
	}

	void Update()
	{
		if (dragging && canMove) {
			
			GetComponent<Collider2D> ().enabled = false;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint (distance);
			transform.position = rayPoint;

		} else if(!dragging) {
			
			GetComponent<Collider2D> ().enabled = true;

		}

		if (Input.GetMouseButton (0)) {

			if (!dragging) {

				if (Input.mousePosition.y > Screen.height / 2) {

					if (Input.mousePosition.x > Screen.width / 2) {

						this.transform.localScale += new Vector3 (0f, val, 0f);

					} else {
						this.transform.localScale -= new Vector3 (0f, val, 0f);
					}

				} else {

					if (Input.mousePosition.x > Screen.width / 2) {

						this.transform.localScale += new Vector3 (val, 0f, 0f);

					} else {
						this.transform.localScale -= new Vector3 (val, 0f, 0f);
					}

				}

			}



		}
	}
}
