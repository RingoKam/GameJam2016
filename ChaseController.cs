using UnityEngine;
using System.Collections;

public class ChaseController : MonoBehaviour
{
    public float speed = 10;
    public GameObject hero;
    private Vector3 _OriginalLocation;
    private bool _isInChaseZone;

    //	void Update()
    //	{
    //		//hero = GameObject.FindGameObjectWithTag("Hero");
    //
    //		Debug.Log(hero.transform.position);
    //
    //	}

    void Awake()
    {
        _OriginalLocation = gameObject.transform.position;
        //Debug.Log(_OriginalLocation);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Hero")
        {
            _isInChaseZone = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Hero")
        {
            Chase();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Hero")
        {
            _isInChaseZone = false; 
        }
    }

    void Update()
    {
        goHome(); 
        Debug.Log(transform.position);
        Debug.Log("this is original location" + _OriginalLocation);
    }

    void goHome()
    {
        if (transform.position != _OriginalLocation && _isInChaseZone == false)
        {
            transform.position = Vector2.Lerp(transform.position, _OriginalLocation, Time.deltaTime * .75f);
        }
    }



    void Chase()
    {
        //Debug.Log("this happen");
        var obj = GetComponentInParent<Transform>();
        //transform.parent.position = Vector2.Lerp(transform.parent.position, hero.transform.position, Time.deltaTime * .75f);
        transform.position = Vector2.Lerp(transform.position, hero.transform.position, Time.deltaTime * .75f);
    }
    
}
