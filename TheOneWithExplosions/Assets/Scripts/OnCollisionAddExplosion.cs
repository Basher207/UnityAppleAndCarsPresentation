using UnityEngine;
using System.Collections;

public class OnCollisionAddExplosion : MonoBehaviour {

	public GameObject explosionPicture;
	public float timeTillNextSplit;

	void OnCollisionEnter2D (Collision2D coll) {
		Vector3 spawnPosition = coll.contacts [0].point;
		Instantiate (explosionPicture, spawnPosition, Quaternion.identity);

//		Vector3 pos = Camera.main.transform.position;
//		pos.x = spawnPosition.x;
//		pos.y = spawnPosition.y;
//
//		Camera.main.transform.position = pos;
//
//		Destroy (gameObject);
		if (timeTillNextSplit < Time.time) {
			timeTillNextSplit = Time.time + timeTillNextSplit;
			Instantiate (gameObject);
		}
	}
}
