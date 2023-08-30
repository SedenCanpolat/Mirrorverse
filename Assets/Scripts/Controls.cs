using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Controls : MonoBehaviour
{

public Action WhenPressR; // empty func

public static Controls controls;

private void Awake() {
    controls = this;
}

private void Update() {
    if(Input.GetKeyDown(KeyCode.R)){
        if(WhenPressR != null){
            WhenPressR();
        }
        
    }
}
 

}