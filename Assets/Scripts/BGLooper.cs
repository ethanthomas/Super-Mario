﻿using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int numBGPanels = 6;

	void Start(){

//		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("Pipe");

//		foreach (GameObject pipe in pipes) {
//			Vector3 pos = pipe.transform.position;
//
//				pos.y = Random.Range(pipeMin, pipeMax);
//				
//				pipe.transform.position = pos;
//		
//				}

		}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Triggered " + collider.name);

		float width = ((BoxCollider2D) collider).size.x;

		Vector3 pos = collider.transform.position;

		pos.x += width * numBGPanels - width/2f;

		collider.transform.position = pos;

//		if (collider.tag == "Pipe") {
//
//
//			pos.y = Random.Range(pipeMin, pipeMax);
//
//
//				}
			collider.transform.position = pos;
	}
}