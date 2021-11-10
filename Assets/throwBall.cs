using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwBall : MonoBehaviour
{

    public Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            anim.SetBool("isThrowing", true);
            Debug.Log("throw");
        }
        else
        {
            anim.SetBool("isThrowing", false);
        }
    }
}
