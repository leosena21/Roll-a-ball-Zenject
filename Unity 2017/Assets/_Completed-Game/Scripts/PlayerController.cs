using UnityEngine;

// Include the namespace required to use Unity UI
using UnityEngine.UI;
using Zenject;

using System.Collections;

public class PlayerController : MonoBehaviour {

	
	// Create public variables for player speed, and for the Text UI game objects
	public float speed;

	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;
    
    // At the start of the game..
    void Start ()
	{
		// Assign the Rigidbody component to our private rb variable
		rb = GetComponent<Rigidbody>();
	}

	// Each physics step..
	void FixedUpdate ()
	{
		// Set some local float variables equal to the value of our Horizontal and Vertical Inputs
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}