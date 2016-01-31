using UnityEngine;
using System.Collections;

public class SpiritController : MonoBehaviour 
{
	public float speed = 5;
	private Rigidbody2D rig;
	private float moveX;
	private float moveY;

	void Start()
	{
		rig = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		moveX = Input.GetAxis("Horizontal");
		moveY = Input.GetAxis("Vertical");

		rig.AddRelativeForce(new Vector2(moveX * speed, moveY * speed));
	}
}
