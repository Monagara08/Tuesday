using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiStone : MonoBehaviour
{

    Rigidbody2D rigid2D;
    float idou = -400.0f;
    float yap = -60.0f;
    float mawaru = -60.0f;
    public AudioClip HenkaSE;
    AudioSource aud;

    //float tomaru = 0.1f;
    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.aud = GetComponent<AudioSource>();
    }


    public void ShootB()
    {
        if (transform.position.y > 3 && transform.position.y < 5)
        {
            this.rigid2D.AddForce(transform.up * this.idou);
        }
        else if (transform.position.y < 3 && transform.position.y > -18)
        {
            this.rigid2D.AddForce(transform.up * this.yap);
            //  this.rigid2D.AddForce(transform.right * this.tomaru);
        }
    }
    private void OnMouseDown()
    {
        if (transform.position.y > 5.1f)
        {
            transform.position = new Vector3(0, 4, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Big")
        {
            gameObject.transform.localScale = new Vector3(
                // gameObject.transform.localScale.x + 1,
                //gameObject.transform.localScale.y + 1,
                //       gameObject.transform.localScale.z);
                2, 2, 0);
        }
        if (other.gameObject.tag == "Small")
        {
            gameObject.transform.localScale = new Vector3(
        0.5f,0.5f,0);
        }
        if (other.gameObject.tag == "Ankou")
        Destroy(gameObject);

        if (other.gameObject.tag == "Woop")
            transform.position = new Vector3(0, -12, 0);
        if (other.gameObject.tag == "Sake" )
        {
            this.rigid2D.AddForce(transform.right * this.mawaru);
            //transform.SetParent(other.transform);
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        this.aud.PlayOneShot(this.HenkaSE);
    }
}