using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    
    private Animator animator;
    private String cameraTag = "MainCamera";

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(cameraTag))
        {
            animator.SetBool("isDancing", true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(cameraTag))
        {
            gameObject.transform.LookAt(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(cameraTag))
        {
            animator.SetBool("isDancing", false);
            animator.SetBool("isWaving", true);
        }
    }
}
