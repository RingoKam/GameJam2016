using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour
{

    public RespawnManager respawnManager; 

    // Use this for initialization
    void Start ()
    {
        respawnManager = FindObjectOfType<RespawnManager>();
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Hero")
        {
            respawnManager.currentCheckPoint = gameObject;
        }
    }
}
