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

    public Anim anim;   //Instpector�� ǥ���� �ִϸ��̼� Class ����
    public Animation _animation;    //�Ʒ��� �ִ� 3D ���� Animation Component�� �����ϱ� ���� ����

  
  void Start () {
		tr = GetComponent<Transform>();

        _animation = GetComponentInChildren<_animation>();
        //�ڽ��� ������ Animation ������Ʈ�� ã�� ������ �Ҵ�

        _animation.clip = anim.idle;
        _animation.Play();
        //Animation ������Ʈ�� Animation Clip �����ϰ� ����
  }
	
	void Update () {
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("vertical");
		
        //�����¿� �̵� ���� ���� ���
		Vector3 movedir = (Vector3.forward * v) + (Vector3.right * h);
		
		tr.Translate (moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);
        //moveDir.nomalized <- Limited 1 = 0.9999999..... (����ȭ)

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
