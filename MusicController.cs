using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {

	static MusicController instance = null;

	// Use this for initialization
	void Awake () {
		if(instance != null){
			Destroy(gameObject);
			print("destroy duplicate music");
		}
		else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

}
