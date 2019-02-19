using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement playerMovement;
	public LevelManager levelManager;

	void Start()
	{
		levelManager = FindObjectOfType<LevelManager>();
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		// Disable player control when obstacle is hit
		if (collisionInfo.transform.tag == "Obstacle")
		{
			playerMovement.enabled = false;
			Invoke("Reset", 2);
		}
	}

	void Reset()
	{
		levelManager.RestartLevel();
	}
}
