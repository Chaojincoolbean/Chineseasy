using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {

//	public Transform rotator;
	//public Transform circle;

	bool beingDragged;
	bool beingrotated;

	public bool frozen;

	// Use this for initialization
	void Start () {
		beingDragged = false;
		beingrotated = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (frozen) {
			return;
		}

		//GETTING THE MOUSE POSITION
		Vector3 mouseScreenPos = Input.mousePosition; //position of mouse on screen
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mouseScreenPos); //convert to world coordinates
		mousePosition.z = 0;//because it will otherwise be at z position of camera


		//WAS THE MOUSE CLICKED
		if (Input.GetMouseButtonDown(0)){ //clicked the left (0) mouseButton

			//is the mouse on this object?
			//RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
			bool overSprite = this.GetComponent<SpriteRenderer>().bounds.Contains(mousePosition);

			if (overSprite) { //mouse clicked this object
				beingDragged = true;
			}
		}
		//WAS THE MOUSE RELEASED
		if (Input.GetMouseButtonUp (0)) {//released the left (0) mouseButton
			
			beingDragged = false;

		}

		//MOVE THE OBJECT IF IT IS BEING DRAGGED
		if (beingDragged == true) {
			transform.position = mousePosition;
		}

		if (Input.GetMouseButton (1)) { 

			bool overSprite = this.GetComponent<SpriteRenderer> ().bounds.Contains (mousePosition);
			if (overSprite) { //mouse clicked this object

				beingrotated = true;

			}
		}


		else if (Input.GetMouseButtonUp (1)) {
			beingrotated = false;
		}


			if (beingrotated == true) {

			
				Vector3 lookPos = Camera.main.ScreenToWorldPoint (mouseScreenPos);

				lookPos = lookPos - transform.position;

				float angle = Mathf.Atan2 (lookPos.y, lookPos.x) * Mathf.Rad2Deg;

				transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
					

			}
		}
				
}
