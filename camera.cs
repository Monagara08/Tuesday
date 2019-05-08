using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    Rigidbody2D rigid2D;
    float idouforce = 30.0f;
    float maxidouspeed = 1.0f;
    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.Rotate(0, (Input.GetAxis("Horizontal") * 1), 0);
        //this.transform.Rotate((Input.GetAxis("Vertical") * 1), 0, 0);
        int key = 0;
        //if (Input.GetKey(KeyCode.UpArrow)) {
        //  transform.Translate(0, 1, 0);
        //}
        //if (Input.GetKey(KeyCode.DownArrow)) {
        //  transform.Translate(0, -1, 0);
        if (Input.GetKey(KeyCode.UpArrow)) key = 1;
        if (Input.GetKey(KeyCode.DownArrow)) key = -1;

        // プレイヤの速度
        float speedy = Mathf.Abs(this.rigid2D.velocity.y);

        // スピード制限
        if (speedy < this.maxidouspeed)
        {
            this.rigid2D.AddForce(transform.up * key * this.idouforce);
        }
    }
    public void UpBDown()
    {
        transform.Translate(0, -0.1f, 0);
    }
    public void DownBDown()
    {
        transform.Translate(0, 0.1f, 0);
    }

}