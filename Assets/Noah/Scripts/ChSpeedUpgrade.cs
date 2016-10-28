using UnityEngine;
using System.Collections;
public class ChSpeedUpgrade : MonoBehaviour {
	
	PlayerStats player;
	Currency currency;
	public void Awake(){
		player = GameObject.Find("Player").GetComponent<PlayerStats>();
		currency = GameObject.Find ("Player").GetComponent<Currency>();
	}
	public void OnClick(){
		if (currency.CurCurrency >= currency.SellingValue) {
			player.PlayerChopSpeed += 10;
		} else {
			Debug.Log ("Not enough currency");
		}
	}
}
