using UnityEngine;
using System.Collections;

public class ExplosionScaleAnimation : MonoBehaviour {

	public AnimationCurve animCurve;

	float startTime;

	void Start () {
		startTime = Time.time;
		Destroy (gameObject, 2f);
	}
	void Update () {
		transform.localScale = Vector3.one * animCurve.Evaluate (Time.time - startTime);
	}
}
