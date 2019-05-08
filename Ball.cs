using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float idou = 50.0f;
    float yap = 5.0f;
    float Yoko = 5.0f;
    float maxYoko = 5.0f;
    float clear = -60.0f;
    float moai = -200.0f;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (transform.position.y > -4 && transform.position.y < 0)
            {
                this.rigid2D.AddForce(transform.up * this.idou);
            }
            else if (transform.position.y < 23 && transform.position.y > 0)
            {
                this.rigid2D.AddForce(transform.up * this.yap);
            }
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxYoko)
        {
            this.rigid2D.AddForce(transform.right * key * this.Yoko);
        }
    }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "dunk")
                SceneManager.LoadScene("dunk anime");
        if (other.gameObject.tag == "Lay-Up")
            SceneManager.LoadScene("Lay-Up");
        if (other.gameObject.tag == "45shoot")
            SceneManager.LoadScene("shoot");

        if (other.gameObject.tag == "block")
            {
                this.rigid2D.AddForce(transform.right * this.clear);
                this.rigid2D.AddForce(transform.up * this.moai);
            }
        }

}
