using UnityEngine;
using System.Collections;

public class PlaySoundOnCollision : MonoBehaviour {

	public AudioClip collisionSound;

	void OnCollisionEnter2D () {
		AudioSource.PlayClipAtPoint (collisionSound, transform.position);
	}
}
