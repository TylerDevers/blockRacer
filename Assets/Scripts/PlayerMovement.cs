using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public int sideThrust = 20;
	public int forwardThrust = 2000;
	public Button leftButton, rightButton;
	LevelManager levelManager;
	Rigidbody rb;
	Touch myTouch;

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
		// touchscreen controls
		if (Input.touchCount > 0)
		{
			myTouch = Input.GetTouch(0);
			float touchPosition = myTouch.position.x;
			if (touchPosition <= Screen.width/2)
			{
				// Debug.Log("left touch");
				rb.AddForce(-transform.right * sideThrust * Time.deltaTime, ForceMode.VelocityChange);
			}
			else if (touchPosition > Screen.width/2)
			{
				// Debug.Log("right touch");
				rb.AddForce(transform.right * sideThrust * Time.deltaTime, ForceMode.VelocityChange);
			}
		}
		// keyboard controls
        else if (Input.GetKey(KeyCode.D))
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
