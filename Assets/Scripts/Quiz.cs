using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
   
    private Canvas canvas;

    private void Start()
    {
        GameObject canvasObj = GameObject.FindGameObjectWithTag("Canvas");
        canvas = canvasObj.GetComponent<Canvas>();
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
