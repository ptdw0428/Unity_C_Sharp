using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class hp_bar : MonoBehaviour {

	public Image hpBar;	//HP Gage Image
	private float total_HP;
	private float minus_HP;

	// Use this for initialization
	void Start () {
		hpBar = gameObject.GetComponent<Image>();
		total_HP = 100;
		minus_HP = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if(Collision){
			hpBar.fillAmount -=minus_HP / total_HP;
		}
	}
}
