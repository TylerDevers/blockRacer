using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;
	public int sideThrust = 20;
	public int forwardThrust = 2000;
	public LevelManager levelManager;

	void Start () 
	{
		rb  = GetComponent<Rigidbody>();
		levelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update ()
    {

        rb.AddForce(transform.forward * forwardThrust * Time.deltaTime);

        Move();
		IfOffTrack();

    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * sideThrust * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * sideThrust * Time.deltaTime, ForceMode.VelocityChange);
        }
    }

    void IfOffTrack()
	{
		if (transform.position.y < -4 && levelManager.levelNotComplete)
		{
			levelManager.RestartLevel();	
		}
	}

}
