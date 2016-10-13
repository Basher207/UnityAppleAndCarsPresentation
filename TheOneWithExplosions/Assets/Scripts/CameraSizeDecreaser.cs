using UnityEngine;
using System.Collections;

public class CameraSizeDecreaser : MonoBehaviour {

	public float sizeDecreasing;

	void FixedUpdate () {
		Camera.main.orthographicSize -= sizeDecreasing;
	}
}
