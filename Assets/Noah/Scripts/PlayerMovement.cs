using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	[SerializeField]
	private float playerSpeed;
	Rigidbody rb;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody>();
	}
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.W)){
			rb.AddForce(Vector3.forward * playerSpeed * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.S)) {
			rb.AddForce(Vector3.back * playerSpeed * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.D)) {
			rb.AddForce (Vector3.right * playerSpeed * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.A)) {
			rb.AddForce (Vector3.left * playerSpeed * Time.deltaTime);
		}
	}
}
