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

    private bool rabbitQuiz = false;
    private bool pandaQuiz = false;
    private bool frogQuiz = false;
    private bool racoonQuiz = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        GameObject canvasObj = GameObject.FindGameObjectWithTag("Canvas");
        canvas = canvasObj.GetComponent<Canvas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (rabbitQuiz) return;
        // && (pandaQuiz || frogQuiz || rabbitQuiz || rabbitQuiz)
        if (other.gameObject.CompareTag(cameraTag))
        {
            animator.SetBool("isDancing", true);
            canvas.enabled = true;
            rabbitQuiz = true;
            // switch (this.gameObject.tag)
            // {
            //     case "Panda":
            //         pandaQuiz = false;
            //         break;
            //     case "Frog":
            //         frogQuiz = false;
            //         break;
            //     case "Racoon":
            //         racoonQuiz = false;
            //         break;
            //     case "Rabbit":
            //         rabbitQuiz = false;
            //         break;
            // }
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


    public void FirstButton()
    {
        Debug.Log("Bralaaaaa");
        // GameObject button = GameObject.FindGameObjectWithTag("Button1");
        // Image image = button.GetComponent<Image>();
        // image.color = new Color(255, 0, 0);
        canvas.enabled = false;
    }

    public void SecondButton()
    {
        Debug.Log("Button 2");
        canvas.enabled = false;
    }

    public void ThirdButton()
    {
        Debug.Log("Button 3");
        canvas.enabled = false;
    }

    public void FourthButton()
    {
        Debug.Log("Button 4");
        canvas.enabled = false;
    }
}