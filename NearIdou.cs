using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearIdou : MonoBehaviour {

    Rigidbody2D rigid2D;
    float idou = -400.0f;
    float yap = -50.0f;
    float yapp = -10.0f;
   
    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }


    public void ShootB()
    {
        if (transform.position.y > 3 && transform.position.y < 5)
        {
            this.rigid2D.AddForce(transform.up * this.idou);
        }
        else if (transform.position.y < 3 && transform.position.y > -14)
        {
            this.rigid2D.AddForce(transform.up * this.yap);
            //  this.rigid2D.AddForce(transform.right * this.tomaru);
        }
        else if (transform.position.y < -14 && transform.position.y > -16)
        {
            this.rigid2D.AddForce(transform.up * this.yapp);
            //  this.rigid2D.AddForce(transform.right * this.tomaru);
        }
    }
}