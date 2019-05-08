using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerYap : MonoBehaviour {

    Rigidbody2D rigid2D;
    Animator animator;
    float idou = 400.0f;
    float yap = 60.0f;
    float tomaru = -60.0f;
    public AudioClip WoopSE;
    AudioSource aud;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void ShootB()
    {
        if (transform.position.y > -4 && transform.position.y < 0)
        {
            this.rigid2D.AddForce(transform.up * this.idou);
            this.aud.PlayOneShot(this.WoopSE);

        }
        else if (transform.position.y < 22 && transform.position.y > 0)
        {
            this.rigid2D.AddForce(transform.up * this.yap);
            this.animator.SetTrigger("yaptrigger");

        }
        else if (transform.position.y > 22)
        {
            this.rigid2D.AddForce(transform.up * this.tomaru);
            //this.tomaru *= 0.8f;
            this.animator.SetTrigger("yaptrigger");

        }
    }
    public void SetB()
    { transform.position = new Vector3(0, -1, 0); }
}