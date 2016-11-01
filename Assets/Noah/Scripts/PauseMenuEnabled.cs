using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool isPause = false;

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPause = !isPause;
		}
		if (isPause) {
			Time.timeScale = 0.0f;
		} else {
			Time.timeScale = 1.0f;
		}
	}



}
