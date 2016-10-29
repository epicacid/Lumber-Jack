using UnityEngine;
using System.Collections;
public class RockHoldUpgrade: MonoBehaviour {

	PlayerStats player;
	Currency currency;
	public void Awake(){
		player = GameObject.Find("Player").GetComponent<PlayerStats>();
		currency = GameObject.Find ("Player").GetComponent<Currency>();
	}
	public void OnClick(){
		if (currency.CurCurrency >= currency.SellingValue) {
			player.RockHold += 10;
		} else {
			Debug.Log ("Not enough currency");
		}
	}
}
