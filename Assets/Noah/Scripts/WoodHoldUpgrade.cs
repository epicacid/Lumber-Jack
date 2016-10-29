using UnityEngine;
using System.Collections;
public class WoodHoldUpgrade : MonoBehaviour {

	PlayerStats player;
	Currency currency;
	public void Awake(){
		player = GameObject.Find("Player").GetComponent<PlayerStats>();
		currency = GameObject.Find ("Player").GetComponent<Currency>();
	}
	public void OnClick(){
		if (currency.CurCurrency >= currency.SellingValue) {
			player.WoodHold += 10;
			currency.CurCurrency -= 25;
		} else {
			Debug.Log ("Not enough currency");
		}
	}
}
