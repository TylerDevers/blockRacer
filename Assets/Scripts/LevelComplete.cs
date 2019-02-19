using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

	LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}
	

	void OnTriggerEnter(Collider collision)
	{
		Debug.Log("Triggered");
		levelManager.CompleteLevel();
	}
}
