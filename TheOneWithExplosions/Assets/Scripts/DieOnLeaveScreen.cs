using UnityEngine;
using System.Collections;

public class DieOnLeaveScreen : MonoBehaviour {

	void OnBecameInvisible () {
		Destroy (gameObject);
	}
}
