using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger("p");
        }

        if(Input.GetKeyUp(KeyCode.U)) 
        {
            animator.SetTrigger("u");
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            animator.SetTrigger("h");
        }
    }
}