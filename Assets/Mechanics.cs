using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics : MonoBehaviour
{
    // Reference to the Animator component
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        // Check if the 'U' key is pressed
        if (Input.GetKeyDown(KeyCode.U))
        {
            // Trigger the animation for 'U'
            animator.SetTrigger("u");
        }

        // Check if the 'P' key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Trigger the animation for 'P'
            animator.SetTrigger("p");
        }

        // Check if the 'H' key is pressed
        if (Input.GetKeyDown(KeyCode.H))
        {
            // Trigger the animation for 'H'
            animator.SetTrigger("h");
        }
    }
}