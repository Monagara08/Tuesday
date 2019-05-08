using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloucon : MonoBehaviour {
    Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
       
        //rb.velocity = new Vector3(1f, 0, 0);

    }
}
