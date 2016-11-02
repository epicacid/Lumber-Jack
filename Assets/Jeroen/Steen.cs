using UnityEngine;
using System.Collections;

public class Steen : MonoBehaviour {


	public int Health; 	




	void Update () 
	{

		if (Health <= 0)
		{
			Destroy(gameObject);
		}
	}

}
