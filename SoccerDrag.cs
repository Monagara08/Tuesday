using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerDrag : MonoBehaviour {


    Rigidbody2D rigid2D;
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {

        if (transform.position.y > -5 && transform.position.y < -1)
        {
            this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }


    void OnMouseDrag()
    {
        if (transform.position.y > -5 && transform.position.y < -1)
        {


            Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
            transform.position = currentPosition;
        }
    }

}
