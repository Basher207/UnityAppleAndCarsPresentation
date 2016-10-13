using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScreenText : MonoBehaviour {
	public static EndScreenText instance;
	public static void PlayerXLost (string playerName) {
		if (!instance.text.enabled) {
			instance.text.text = "Player " + playerName + " Lost";
			instance.text.enabled = true;
		}
	}
	Text text;
	void Awake () {
		text = GetComponent<Text> ();
		text.enabled = false;
		instance = this;
	}
}
