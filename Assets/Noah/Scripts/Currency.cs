using UnityEngine;
using System.Collections;

public class Currency : MonoBehaviour {
	[SerializeField]
	private int curCurrency;
	[SerializeField]
	private int sellingValue = 25;

	void Start(){
		curCurrency = 100;
	}

	public int CurCurrency{
		get{
			return curCurrency;
		}set{
			curCurrency = value;
		}
	}
	public int SellingValue{
		get{
			return sellingValue;
		}set{
			sellingValue = value;
		}
	}
}
