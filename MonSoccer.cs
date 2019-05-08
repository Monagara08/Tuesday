using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonSoccer : MonoBehaviour
{

    Animator animator;
        void Start()
    {
        this.animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    public void ShootB()
    {
        this.animator.SetTrigger("ShootTrigger");
    }
}