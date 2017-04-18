using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderTrigger : MonoBehaviour {


	public bool col;

	// Use this for initialization
	void Start () {

		col = false;
	}
	
	// Update is called once per frame
//	void Update() {
//
//		col = false;
//
//	}

	void OnTriggerEnter2D(Collider2D collider)
	{		col = true;


	}

	void OnTriggerExit2D(Collider2D collider){
		col = false;

	}
		
}
