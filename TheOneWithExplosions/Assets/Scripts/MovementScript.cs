using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	Rigidbody2D rigidBody;

	public float force;
	public float rotationalForce;

	public KeyCode moveUpKey;
	public KeyCode moveDownKey;
	public KeyCode rotateRightKey;
	public KeyCode rotateLeftKey;


	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		if (Input.GetKey (moveUpKey))
			rigidBody.AddForce (transform.right * force);
		if (Input.GetKey (moveDownKey))
			rigidBody.AddForce (-transform.right * force);

		if (Input.GetKey (rotateLeftKey))
			rigidBody.AddTorque(rotationalForce);
		if (Input.GetKey (rotateRightKey))
			rigidBody.AddTorque (-rotationalForce);
		
	}
	void OnCollisionEnter2D (Collision2D coll) {
		force += 1;
	}
	void OnDestroy () {
		EndScreenText.PlayerXLost (name);
	}
}
