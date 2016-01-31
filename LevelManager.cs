using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{

	public void levelManager(string name)
	{
		SceneManager.LoadScene(name);
	}

}
