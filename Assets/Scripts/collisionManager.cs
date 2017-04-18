using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManager : MonoBehaviour {


	public colliderTrigger[] colliderTriggers;
	public Transform one;
	public bool inplace;


	// Use this for initialization
	void Start () {
		inplace = false;

	}
	
	// Update is called once per frame
	void Update () {

		int count = 0;

		foreach (colliderTrigger ct in colliderTriggers) {
			if (ct.col == true) {
				count++;
			}
		}

		if (count == colliderTriggers.Length) {
			
			one.position = transform.position;
			one.rotation = transform.rotation;
			one.GetComponent<MouseDrag> ().frozen = true;
			inplace = true;
		}
	}
}
