using UnityEngine;
using System.Collections;

public class BirdTouchPlayerRespawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = obj.transform.position;	
	}

	public GameObject obj;

}
