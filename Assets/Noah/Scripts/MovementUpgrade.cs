using UnityEngine;
using System.Collections;
public class MovementUpgrade: MonoBehaviour {

	PlayerStats player;
	Currency currency;
	public void Awake(){
		player = GameObject.Find("Player").GetComponent<PlayerStats>();
		currency = GameObject.Find ("Player").GetComponent<Currency>();
	}
	public void OnClick(){
		if (currency.CurCurrency >= currency.SellingValue) {
			player.MovSpeed += 10;
		} else {
			Debug.Log ("Not enough currency");
		}
	}
}
