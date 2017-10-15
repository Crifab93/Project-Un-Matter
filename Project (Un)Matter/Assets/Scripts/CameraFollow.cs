using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform playerTransform;

	void Start(){
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}

	//after Update()
	void LateUpdate(){
		transform.position = playerTransform.position;
	}
}
