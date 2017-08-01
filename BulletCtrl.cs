using UnityEngine;
using System.Collections;

public class BulletCtrl : MonoBehaviour
{
    public int damage = 20;
    public int speed = 1000.0f;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }
}
