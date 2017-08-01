using System.Collections;
using UnityEngine;

public class Score_bar : MonoBehaviour {
  private float h = 0.0f;
  private float v = 0.0f;
  
  private Transform tr;
  public float move_speed = 10.0f;    //Speed
  
  void Start () {
  tr = GetComponent<Transform>();
  }
	
	void Update () {
		h = Input.GetAxis("Horizontal");
  		v = Input.GetAxis("vertical");
		
		Vector3 movedir = (Vector3.forward * v) + (Vector3.right * h);
		
		tr.Translate (moveDir * Time.deltaTime * moveSpeed, Space.Self);
	}
}
