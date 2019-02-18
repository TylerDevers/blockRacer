using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;
	public int sideThrust = 20;
	public int forwardThrust = 2000;
	
	void Start () 
	{
		rb  = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

		rb.AddForce(transform.forward * forwardThrust * Time.deltaTime);

		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce(transform.right * sideThrust * Time.deltaTime, ForceMode.VelocityChange);
		} else if (Input.GetKey(KeyCode.A))
		{
			rb.AddForce(-transform.right * sideThrust * Time.deltaTime, ForceMode.VelocityChange);
		}
	}

}
