using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    
    private Animator animator;
    private String cameraTag = "Camera";
    private Canvas canvas;

    private void Start()
    {
        animator = GetComponent<Animator>();
        GameObject canvasObj = GameObject.FindGameObjectWithTag("Canvas");
        canvas = canvasObj.GetComponent<Canvas>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(cameraTag))
        {
            animator.SetBool("isDancing", true);
            canvas.enabled = true;
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
