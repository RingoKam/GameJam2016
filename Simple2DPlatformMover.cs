// Simple 2D Platform Mover
// Script by Jarrod Rizor

using UnityEngine;
using System.Collections;

public class Simple2DPlatformMover : MonoBehaviour {
	
	// Public Variables
	// Allows users to adjust Horizontal and Vertical Speed and the amplitude of the object
	public int horizontalDistance = 0;
	public int verticalDistance = 10;
	[Range(0, 10)] public int horizontalSpeed = 0;
	[Range(0, 10)] public int verticalSpeed = 3;

	// Private Variables for the transforms placement
	private Vector3 objPos;
	
	private float horizonalStartPosition;
	private float verticalStartPosition;
	
	// Base force to multiply by
	private float baseForce = .005f;
	
	// Variable to check if rigidbody is on collider.
	private bool RigOnCol;
	
	void Awake()
	{
		// When game starts, set RigOnCol to false.
		RigOnCol = false;
	
		horizonalStartPosition = transform.position.x;
		verticalStartPosition = transform.position.y;
	}
	
	void OnCollisionStay2D(Collision2D obj)
	{
		// If a rigidbody lands on a collider and if RigOnCol isn't false
		if(obj.rigidbody != null && RigOnCol == false)
		{
			// Set RigOnCol to true and parent the obj object to the collider 
			RigOnCol = true;
			obj.transform.parent = gameObject.transform;
		}
	}
	
	void OnCollisionExit2D(Collision2D obj)
	{
		// When the obj leaves the collider, unparent it.
		RigOnCol = false;
		obj.transform.parent = null;
	}
	
	
	void FixedUpdate()
	{
		
		// Makes sure that the object is in the spot 
		// Move Objects based off the values based from the Unity editor.
		// Math absolute value to prevent a negative value, Sin/Cos function with time * spped to get nice tween motion
		// times the distance to move the object a given distance and applied to the start posistion of the object. 
		
		
		// Move Objects based off the values based from the Unity editor. 
		objPos.x = (Mathf.Sin(Time.fixedTime * horizontalSpeed) * (horizontalDistance * 10)) * baseForce + horizonalStartPosition;
		objPos.y = (Mathf.Sin(Time.fixedTime * verticalSpeed) * (verticalDistance * 10)) * baseForce + verticalStartPosition;
		transform.position = objPos; // placed the object based of the x and y values of the vector
		
	}
}
