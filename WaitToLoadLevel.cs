using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WaitToLoadLevel : MonoBehaviour 
{
	public string level;

	void loadLevel()
	{
		SceneManager.LoadScene(level);
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.name == "Hero")
		{
			//StartCoroutine(LoadLevelAfterTime());
			loadLevel();
		}
	}

	IEnumerator LoadLevelAfterTime() {
        print(Time.time);
        yield return new WaitForSeconds(4f);
        loadLevel();
    }
}
