using UnityEngine;
using System.Collections;

public class WallCtrl : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)   //충돌이 시작할 때
    {
        if (coll.collider.tag == "BULLET")
        {
            Destroy(coll.gameObject);   //충돌한 GameObject 삭제
        }
    }
}
