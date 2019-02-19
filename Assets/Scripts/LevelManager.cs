using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public GameObject levelCompletedUI;
	
	public void RestartLevel()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void CompleteLevel()
	{
		levelCompletedUI.SetActive(true);
		Invoke("LoadNextLevel", 2);
	}

	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
