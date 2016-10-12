using UnityEngine;
using System.Collections;

public class DestroyOnNotVisible : MonoBehaviour {

	void OnBecameInvisible () {
		Destroy (gameObject);
	}
}
