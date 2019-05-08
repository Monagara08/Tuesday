using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour {

    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;
    GameObject director;
    Transform tf;

    void Start() {
        this.director = GameObject.Find("neoGameDirector");
        this.aud = GetComponent<AudioSource>();
        tf = transform;
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Ringo") {
            this.director.GetComponent<neoGameDirector>().GetApple();
            this.aud.PlayOneShot(this.appleSE);
        } else {
            this.director.GetComponent<neoGameDirector>().GetBomb();
            this.aud.PlayOneShot(this.bombSE);
        }
        Destroy(other.gameObject);    
    }
    
    void Update(){
    if (Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,Mathf.Infinity)){
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                tf.position = new Vector3(x, 0.2f, z);
            }
        }
	}
}