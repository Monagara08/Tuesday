using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusen : MonoBehaviour {

    float move = 0.04f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, move, 0);
        if (transform.position.y > 6.0f || transform.position.y < -1.0f)
        {
            move *= -1;
        }
    }
}