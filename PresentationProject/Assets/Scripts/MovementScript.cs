using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	Rigidbody2D rigidBody;

	public float upDownSpeed;
	public float rotationForce;

	public KeyCode moveUpKey;
	public KeyCode moveDownKey;
	public KeyCode moveRightKey;
	public KeyCode moveLeftKey;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (moveUpKey))
			rigidBody.AddForce (transform.up * upDownSpeed);
		if (Input.GetKey (moveDownKey))
			rigidBody.AddForce (-transform.up * upDownSpeed);



		if (Input.GetKey (moveLeftKey))
			rigidBody.AddTorque (rotationForce);
		if (Input.GetKey (moveRightKey))
			rigidBody.AddTorque (-rotationForce);
	}
}
