using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneを使えるように

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 780.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;
    public AudioClip jumpSE;
    public AudioClip boyonSE;
    AudioSource aud;
    int ratio = 2;
    int key = 1;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        // ジャンプする
        if (Input.GetMouseButton(0) &&
            this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            int dice = Random.Range(1, 11);
            if(dice <= this.ratio) {
                this.aud.PlayOneShot(this.boyonSE);
            } else {
                this.aud.PlayOneShot(this.jumpSE);
            }
        }
       
        // 左右移動
        int key = 0;
        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // プレイヤの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // 動く方向に応じて反転(追加)
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // プレイヤの速度に応じてアニメーション速度を変える
        if (this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        //画面外に出た場合はゲームオーバー画面へ
        if(transform.position.y < -10) {
            SceneManager.LoadScene("GameOverScene");
        }
    }
  

    // ゴールに到達
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "flag") {
         //   Debug.Log("ゴール");
            SceneManager.LoadScene("ClearScene");
        }
    }
   // void OnCollisionEnter2D(Collision col)
  //  {
       // if (col.gameObject.tag == "MoveStage")
      //  {
           // transform.parent = col.gameObject.transform;
            //transform.SetParent(col.transform);
           // Debug.Log("OK");
       // }
        void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.tag == "MoveStage")
        {
                transform.SetParent(col.transform);
            }else if(col.gameObject.tag == "oki")
        {
            transform.SetParent(col.transform);
        }
    }
     void OnCollisionExit2D(Collision2D col)
     {
    if (col.gameObject.tag == "MoveStage")
    {
    transform.SetParent(null);
     }
    }
}
