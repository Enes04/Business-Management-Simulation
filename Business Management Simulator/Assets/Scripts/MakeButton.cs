﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MakeButton : MonoBehaviour
{

     public GameObject definedButton;
     public UnityEvent OnClick = new UnityEvent();
 
     // Use this for initialization
     void Start () {
         definedButton = this.gameObject;
     }
     
     // Update is called once per frame
     void Update () {
         var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit Hit;
         
         if (Input.GetMouseButtonDown(0))
         {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log("Button Clicked");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                OnClick.Invoke();
            }
         }    
     }
}
