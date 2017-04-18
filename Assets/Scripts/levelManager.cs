using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

	public AudioSource audio;

	private GameObject[] cms;
	private int count;
	public int score;

	// Use this for initialization
	void Start () {
		cms = GameObject.FindGameObjectsWithTag ("hua");
		count = 0;
		score = 0;

		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		count = 0;
		
		foreach (GameObject ct in cms) {

			if (ct.GetComponent<collisionManager>().inplace == true) {
				count++;
			}
		}

		if ( count == cms.Length) {
			Debug.Log ("ok");
			score++;
			Debug.Log(score);

		}
	}
}
