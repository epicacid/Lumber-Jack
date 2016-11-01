using UnityEngine;
using System.Collections;
public class ChSpeedUpgrade : MonoBehaviour {
	
	PlayerManager player;
	Currency currency;
	public void Awake(){
		player = GameObject.Find("Player").GetComponent<PlayerManager>();
		currency = GameObject.Find ("Player").GetComponent<Currency>();
	}
	public void OnClick(){
		if (currency.CurCurrency >= currency.SellingValue) {
			//player.PlayerChopSpeed += pla;
			currency.CurCurrency -= 25;
		} else {
			Debug.Log ("Not enough currency");
		}
	}
}
