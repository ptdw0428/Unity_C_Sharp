using System.Collections;
using UnityEngine;

public class FollowCam : MonoBehaviour {
  
     public Transform targetTr;  //Target Object Transform variable
     public float dist = 10.0f;  //Distance to camera
     public float height = 3.0f  //Camera height
     public float dampTrace = 20.0f; //Smooth Follow Cam Variable;
  
     private Transform tr;   //Camera's Transform variable
  
     void Start(){
       tr = GetComponent<Transform>();
      }
  
     void LateUpdate(){
        tr.position = Vector3.Lerp(tr.position, 
        targetTr.position - (targetTr.forward * dist) + (Vector3.up * height), 
        Time.deltaTime * dampTrace);

        //Vector3.Lerp (Vector3 ������ġ, Vector3 ������ġ, float �ð�)
    
        tr.LookAt(targetTr, position);
  }
}
