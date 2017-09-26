using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winTrigger : MonoBehaviour {

	public Text win;
	void OnTriggerEnter() {
		win.text = "You win!";
	}
}