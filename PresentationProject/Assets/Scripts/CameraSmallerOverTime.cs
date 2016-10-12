using UnityEngine;
using System.Collections;

public class CameraSmallerOverTime : MonoBehaviour {

	public float decreasedCameraSizePerSecond;

	void FixedUpdate () {
		Camera.main.orthographicSize -= decreasedCameraSizePerSecond;
	}
}
