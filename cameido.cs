using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cameido : MonoBehaviour
{

    bool push = false;

    public void PushDown()
    {
        push = true;
    }

    public void PushUp()
    {
        push = false;
    }

    void Update()
    {
        if (push == true)
        {
            DownB();
        }
    }

    public void DownB()
    {
        transform.Translate(0, -0.25f, 0);
    }
    public void SetB()
    { transform.position = new Vector3(0, 5, -10); }
}