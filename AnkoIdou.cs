using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnkoIdou : MonoBehaviour {
    float move = 1.8f;
    public AudioClip PakuPakuSE;
    AudioSource aud;
    void Start()
    {
        this.aud = GetComponent<AudioSource>();

    }

    void Update()
    {
        transform.Translate(move * Time.deltaTime, 0, 0);
        if (transform.position.x < -3 || transform.position.x > 3)
        {
            move *= -1;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        this.aud.PlayOneShot(this.PakuPakuSE);
    }


}