using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_bar : MonoBehaviour {

  public Text score_bar_text;
  private int score_total;
  
	void Start () {
		score_bar_text = gameObject.GetComponent<Text>();
    		score_total = 0;
	}
	
	void Update () {
		if (!Collision){
      			AddScore(10);
   	 	}
		if(score_total == 150){
			SceneManager.LoadScene("Clear");	//If score is over 150 point, Change the Claer Scene!
		}
	}
  
  	void AddScore(int score){
    		score_total += score;
    		score_bar_text = "Score : " + score_total.ToString();
 	}
}
