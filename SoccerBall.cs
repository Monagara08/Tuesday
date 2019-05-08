using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoccerBall : MonoBehaviour
{


    Rigidbody2D rigid2D;
    float idou = 400.0f;
    float yap = 60.0f;
    float mawaru = 60.0f;
    float moai = -1200f;
    float clear = -500f;
    //float tomaru = 0.1f;
    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }


    public void ShootB()
    {
        if (transform.position.y > -4 && transform.position.y < -1)
        {
            this.rigid2D.AddForce(transform.up * this.idou);
        }
        else if (transform.position.y < 23 && transform.position.y > -1)
        {
            this.rigid2D.AddForce(transform.up * this.yap);
            //  this.rigid2D.AddForce(transform.right * this.tomaru);
        }
    }
    private void OnMouseDown()
    {
        if (transform.position.y < -4)
        {
            transform.position = new Vector3(0, -2, 0);
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
                1.7f, 1.7f, 0);
        }
        if (other.gameObject.tag == "Small")
        {
            gameObject.transform.localScale = new Vector3(
        0.5f, 0.5f, 0);
        }
        if (other.gameObject.tag == "Sake")
        {
            this.rigid2D.AddForce(transform.right * this.mawaru);
            //transform.SetParent(other.transform);
        }
        if (other.gameObject.tag == "Ankou")
        {
            this.rigid2D.AddForce(transform.right * this.clear);
            this.rigid2D.AddForce(transform.up * this.moai);
            //transform.SetParent(other.transform);

        }
        if (other.gameObject.tag == "Goal")
            SceneManager.LoadScene("Goal");
    }
}