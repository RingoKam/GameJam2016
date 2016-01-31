using UnityEngine;
using System.Collections;


//RespawnManager
public class RespawnManager : MonoBehaviour
{
    public GameObject currentCheckPoint;
    public GameObject hero;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RespawnHero()
    {
        hero.transform.position = currentCheckPoint.transform.position; 
    }

}
