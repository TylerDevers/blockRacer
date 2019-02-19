using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	public void RestartLevel()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
