using UnityEngine;
using System.Collections;

public class Hout : MonoBehaviour {
	public int Health;


	void Update () 
	{

		if (Health <= 0)
		{
			Destroy(gameObject);
		}
	}

}