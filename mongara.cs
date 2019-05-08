using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mongara : MonoBehaviour {

    Rigidbody2D rigid2D;
    float idou = -300.0f;
    public AudioClip WoopSE;
    AudioSource aud;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void ShootB()
    {
        if (transform.position.y > 5 && transform.position.y < 7)
        {
            this.rigid2D.AddForce(transform.up * this.idou);
            this.aud.PlayOneShot(this.WoopSE);
        }



    }
    public void SetB()
    { transform.position = new Vector3(0, 5.5f, 0); }
}
