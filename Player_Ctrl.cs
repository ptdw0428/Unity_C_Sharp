using System.Collections;
using UnityEngine;

[System.Serializable]
public class Anim
{
    public AnimationClip idle;
    public AnimationClip runForward;
    public AnimationClip runBackward;
    public AnimationClip runRight;
    public AnimationClip runLeft;
}

public class Player_Ctrl : MonoBehaviour {
    private float h = 0.0f;
    private float v = 0.0f;
  
    private Transform tr;
    public float move_speed = 10.0f;    //Speed
    public float rotSpeed = 100.0f; //Rotation Speed

    public Anim anim;   //Instpector에 표시할 애니메이션 Class 변수
    public Animation _animation;    //아래에 있는 3D 모델의 Animation Component에 접근하기 위한 변수

  
  void Start () {
		tr = GetComponent<Transform>();

        _animation = GetComponentInChildren<_animation>();
        //자신의 하위에 Animation 컴포넌트를 찾아 변수에 할당

        _animation.clip = anim.idle;
        _animation.Play();
        //Animation 컴포넌트의 Animation Clip 지정하고 실행
  }
	
	void Update () {
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("vertical");
		
        //전후좌우 이동 방향 벡터 계산
		Vector3 movedir = (Vector3.forward * v) + (Vector3.right * h);
		
		tr.Translate (moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);
        //moveDir.nomalized <- Limited 1 = 0.9999999..... (정규화)

        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));

        if(v >= 0.1f)   //Forward
        {
            _animation.CrossFade(anim.runForward.name, 0.3f);
        }
        else if (v <= -0.1f)    //Back
        {
            _animation.CrossFade(anim.runBackward.name, 0.3f);
        }
        else if (h >= 0.1f) //right
        {
            _animation.CrossFade(anim.runRight.name, 03.f);
        }
        else if (h <= -0.1f)
        {   //Left
            _animation.CrossFade(anim.runLeft.name, 0.3f);
        }
        else
        {   //Stop Animation
            _animation.CrossFade(anim.idle.name, 0.3f);
        }
        
	}
}
