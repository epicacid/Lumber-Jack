using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	[SerializeField]
	private float playerChopSpeed = 10.0f;
	[SerializeField]
	private int woodHold = 10;
	[SerializeField]
	private int rockHold = 10;
	[SerializeField]
	private float movSpeed = 10.0f;

	public float PlayerChopSpeed{
		get{
			return playerChopSpeed;
		}set{
			playerChopSpeed = value;
		}
	}
}
