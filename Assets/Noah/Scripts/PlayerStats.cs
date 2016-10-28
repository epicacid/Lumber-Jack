using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	[SerializeField]
	private int playerChopSpeed = 10;
	[SerializeField]
	private int woodHold = 10;
	[SerializeField]
	private int rockHold = 10;
	[SerializeField]
	private int movSpeed = 10;

	public int PlayerChopSpeed{
		get{
			return playerChopSpeed;
		}set{
			playerChopSpeed = value;
		}
	}
	public int WoodHold{
		get{
			return woodHold;
		}set{
			woodHold = value;
		}
	}
	public int RockHold{
		get{
			return rockHold;
		}set{
			rockHold = value;
		}
	}
	public int MovSpeed{
		get{
			return movSpeed;
		}set{
			movSpeed = value;
		}
	}
}


