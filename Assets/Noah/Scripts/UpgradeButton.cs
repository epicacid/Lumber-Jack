using UnityEngine;
using System.Collections;


public class UpgradeButton : MonoBehaviour {

	PlayerStats player;


	public void Awake(){
		player = GameObject.Find("Player").GetComponent<PlayerStats>();
	}


	public void OnClick(){
		player.PlayerChopSpeed += 10;


	}

}
