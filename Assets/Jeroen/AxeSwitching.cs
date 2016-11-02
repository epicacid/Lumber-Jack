using UnityEngine;
using System.Collections;

public class AxeSwitching : MonoBehaviour {
	public GameObject Axe;
	public GameObject Pickaxe;





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("1")) {
			Axe.SetActive (true);
			Pickaxe.SetActive (false);
			Debug.Log ("Axe");
		}

			
		if (Input.GetKeyDown ("2")) {
			Axe.SetActive (false);
			Pickaxe.SetActive (true);
			Debug.Log ("Pickaxe");
		}
	}
}
