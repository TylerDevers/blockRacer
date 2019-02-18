using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement playerMovement;

	void OnCollisionEnter(Collision collisionInfo)
	{
		// Disable player control when obstacle is hit
		if (collisionInfo.transform.tag == "Obstacle")
		{
			playerMovement.enabled = false;
		}
	}
}
