﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Touch : MonoBehaviour
{   
    Ray ray;
    public GameObject buttonExample;



    private void Update(){
    
        if(Input.touchCount > 0){
            ray = Camera.main.ScreenPointToRay(UnityEngine.Input.GetTouch(0).position);

            if (Physics.Raycast (ray, Mathf.Infinity)){
                Debug.Log("Hit Something");
                buttonExample.SetActive(true);
            }
        }
    	
    }

}
