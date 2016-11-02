using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gathering : MonoBehaviour {



	public float hout = 0f;
	public float steen = 0f;
	Camera camera;
	private Hout Wood;
	private Steen Stone;
	private float ClickedHout = 0f;
	private float ClickedStone = 0f;



	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera>();
		Wood = GameObject.FindGameObjectWithTag ("Wood").GetComponent<Hout> ();
		Stone = GameObject.FindGameObjectWithTag ("Stone").GetComponent<Steen> ();


	}

	// Update is called once per frame
	void Update () {
		Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit)){
			print("I'm looking at " + hit.transform.name);

			if(hit.collider.CompareTag ("Stone"))
			{
				if (Input.GetKeyDown (KeyCode.Mouse0)) {
					ClickedStone += 1f;
					Debug.Log (ClickedStone);
					if (ClickedStone == 5) {
						steen += 1f;
						--Stone.Health;
						ClickedStone = 0;
						Debug.Log (ClickedStone);
					}

				}

			}
			if(hit.collider.CompareTag ("Wood"))
			{
				if (Input.GetKeyDown (KeyCode.Mouse0)) {
					ClickedHout += 1f;
					Debug.Log (ClickedHout);
					if (ClickedHout == 5) {
						hout += 1f;
						--Wood.Health;
						ClickedHout = 0;
						Debug.Log (ClickedHout);
					}
				}

			}
		}

	}
}




