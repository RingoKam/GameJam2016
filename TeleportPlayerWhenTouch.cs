using UnityEngine;
using System.Collections;

public class TeleportPlayerWhenTouch : MonoBehaviour {

	public RespawnManager respawnManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D col)
	{
		print(col.tag);

		if (col.tag == "Hero")
		{
            Debug.Log("this just happened");
			respawnManager.RespawnHero();
		}
	}
}
