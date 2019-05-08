using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

    Transform tf;

    public float dropSpeed = -0.03f;


    void Start()
    {
        Application.targetFrameRate = 60;
        tf = transform;

    }
    void Update () {
        tf.Translate(0, this.dropSpeed, 0);
        if(transform.position.y < -1.0f) {
            Destroy(gameObject);
        }
	}
}